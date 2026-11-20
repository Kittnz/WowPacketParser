using System;
using System.Text;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Parsing.Parsers
{
    public static class WardenHandler
    {
        [Parser(Opcode.SMSG_WARDEN_DATA)]
        public static void HandleServerWardenData(Packet packet)
        {
            packet.AsHex();
            packet.ReadToEnd();
            /*
            var opcode = packet.ReadByteE<WardenServerOpcode>("Warden Server Opcode");

            packet.SetPosition(0);

            switch (opcode)
            {
                case WardenServerOpcode.ModuleInfo:
                {
                    packet.ReadByte();
                    packet.ReadBytes("Module MD5", 16);
                    packet.ReadBytes("Module RC4", 16);
                    packet.ReadUInt32("Module Length");
                    break;
                }
                case WardenServerOpcode.ModuleChunk:
                {
                    packet.ReadByte();

                    var length = packet.ReadUInt16("Chunk Length");
                    packet.ReadBytes("Module Chunk", length);
                    break;
                }
                case WardenServerOpcode.CheatChecks:
                {
                    packet.ReadByte();

                    byte length;
                    while ((length = packet.ReadByte()) != 0)
                    {
                        packet.ReadBytes("String", length);
                    }

                    // var rest = (int)(packet.GetLength() - packet.GetPosition());
                    break;
                }
                case WardenServerOpcode.Data:
                {
                    while (packet.CanRead())
                    {
                        packet.ReadByte();

                        var length = packet.ReadUInt16("Data Length");
                        packet.ReadInt32("Data Checksum");
                        packet.ReadBytes("Data", length);
                    }
                    break;
                }
                case WardenServerOpcode.Seed:
                {
                    packet.ReadByte();
                    packet.ReadBytes("Seed", 16);
                    break;
                }
            }
            */
        }

        [Parser(Opcode.CMSG_WARDEN_DATA)]
        public static void HandleClientWardenData(Packet packet)
        {
            packet.AsHex();
            packet.ReadToEnd();
            /*
            var opcode = packet.ReadByteE<WardenClientOpcode>("Warden Client Opcode");

            switch (opcode)
            {
                case WardenClientOpcode.CheatCheckResults:
                {
                    var length = packet.ReadUInt16("Check Result Length");
                    packet.ReadInt32("Check Result Checksum");
                    packet.ReadBytes("Check Results", length);

                    break;
                }
                case WardenClientOpcode.TransformedSeed:
                {
                    packet.ReadBytes("SHA1 Seed", 20);
                    break;
                }
            }
            */
        }

        // ---- Warden3 (1.13.x / 2.5.x / 3.4.x / 1.14.x): SMSG_WARDEN3_DATA, CMSG_WARDEN3_DATA ----
        // Layouts taken from the client side Warden implementation (wowclassic_1132 docs/warden-handbook.md, tools/sniff/warden_reports.py).
        // SMSG_WARDEN3_DATA: u32 length + data (scan request {nonce, FNV-1a32(nonce)}, module delivery "WMP\0", sub module traffic).
        // CMSG_WARDEN3_DATA: u32 token + u32 length + data (hello/ack, or a report sealed with RC5-32/12 CBC).

        private static readonly byte[] Warden3SealKey = { 0xd3, 0x2b, 0xbe, 0x38, 0xa0, 0xbc, 0x00, 0xe9, 0xdd, 0x71, 0xaf, 0x10, 0x4c };
        private static uint[] _warden3Rc5Table;

        public static void ReadWarden3ServerData(Packet packet)
        {
            var len = packet.ReadInt32("Length");
            if (len < 0 || len > packet.Length - packet.Position)
                len = (int)(packet.Length - packet.Position);
            var data = packet.ReadBytes(len);

            if (len == 8)
            {
                var hash = BitConverter.ToUInt32(data, 4);
                packet.AddValue("PacketKind", "Scan request");
                packet.AddValue("RequestNonce", $"0x{BitConverter.ToUInt32(data, 0):X8}");
                packet.AddValue("RequestHash", $"0x{hash:X8} (FNV-1a32 of nonce, {(Fnv1a32(data, 0, 4) == hash ? "valid" : "INVALID")})");
                return;
            }

            if (len >= 12 + 256 && data[0] == (byte)'W' && data[1] == (byte)'M' && data[2] == (byte)'P' && data[3] == 0)
            {
                var packed = BitConverter.ToUInt32(data, 4);
                packet.AddValue("PacketKind", "Warden module (WMP), RSA signed, zlib compressed");
                packet.AddValue("PackedSize", $"{packed} bytes ({(packed == len - 268 ? "matches packet" : "MISMATCH with packet")})");
                packet.AddValue("UnpackedSize", $"{BitConverter.ToUInt32(data, 8)} bytes");
                packet.AddValue("Signature", Utilities.ByteArrayToHexString(Slice(data, 12, 16)) + " ... (256 bytes)");
                return;
            }

            AddEncrypted(packet, data);
        }

        public static void ReadWarden3ClientData(Packet packet)
        {
            packet.ReadUInt32("SessionToken");
            var len = packet.ReadInt32("Length");
            if (len < 0 || len > packet.Length - packet.Position)
                len = (int)(packet.Length - packet.Position);
            var data = packet.ReadBytes(len);

            if (len == 8 && BitConverter.ToUInt32(data, 0) == 0)
            {
                // outer type 101 (hello, pid) or the ack of a module delivery (module index)
                packet.AddValue("HelloPidOrModuleAckIndex", BitConverter.ToUInt32(data, 4));
                return;
            }

            if (len >= 0x20 && (len & 0xf) == 0)
            {
                var d = DecryptWarden3Report(data);
                var ck = BitConverter.ToUInt32(d, 0x10);
                var type = d[0x14];
                var category = d[0x15];
                var plen = BitConverter.ToUInt16(d, 0x16);
                if (0x18 + plen <= d.Length && Fnv1a32(d, 0x14, 4 + plen) == ck)
                {
                    ReadWarden3ReportPayload(packet, type, category, Slice(d, 0x18, plen));
                    return;
                }
            }

            AddEncrypted(packet, data);
        }

        // Report categories of the sealed client reports (client docs: warden-checks-reference.md, warden-scan-values.md)
        private static string Warden3Category(byte category)
        {
            switch (category)
            {
                case 0x01: return "ScanReport (category 0x01)";
                case 0x21: return "ModuleIntegrity (category 0x21)";
                case 0x22: return "LoaderStatus (category 0x22)";
                default: return $"Unknown (category 0x{category:X2})";
            }
        }

        private static void ReadWarden3ReportPayload(Packet packet, byte type, byte category, byte[] payload)
        {
            if (type == 1 && category == 0x21 && payload.Length >= 0x2b)
            {
                // integrity burst: scrambled descriptor of a loaded module (first u32 = scramble seed)
                var d = (byte[])payload.Clone();
                var k = BitConverter.ToUInt32(d, 0);
                var end = d.Length & ~3;
                for (var o = 4; o + 4 <= end; o += 4)
                {
                    k = Rol(k, 1);
                    var c = BitConverter.ToUInt32(d, o);
                    BitConverter.GetBytes(c ^ k).CopyTo(d, o);
                    k ^= Rol(c, 5);
                }

                if (d[4] == 1 && BitConverter.ToUInt32(d, 6) == d.Length - 10)
                {
                    string moduleName = null;
                    string pdbName = null;
                    var pdbOnFixedDrive = false;
                    if (d[5] < 3)
                    {
                        pdbOnFixedDrive = d[0x2a] != 0;
                        var nameBytes = BitConverter.ToUInt32(d, 0x22);
                        var pdbLen = BitConverter.ToUInt32(d, 0x26);
                        if (nameBytes >= 2 && 0x2b + nameBytes - 2 <= d.Length)
                        {
                            var nameLen = (int)nameBytes - 2;
                            moduleName = Encoding.Unicode.GetString(d, 0x2b, nameLen);
                            var pdbOfs = 0x2b + nameLen + 2;
                            if (pdbLen > 1 && pdbOfs + pdbLen <= d.Length)
                                pdbName = Encoding.ASCII.GetString(d, pdbOfs, (int)pdbLen - 1);
                        }
                    }
                    else
                    {
                        // version 3 (1.13.6+/2.5.x+): the fixed fields after +0x22 are followed by a copy of the PE header and the
                        // section table; layout not decoded, so find the UTF-16 path ("X:\") and the ASCII pdb name by scanning
                        for (var i = 0x22; i + 6 < d.Length; i++)
                        {
                            if (d[i] < 0x41 || d[i] > 0x7a || d[i + 1] != 0 || d[i + 2] != (byte)':' || d[i + 3] != 0 || d[i + 4] != (byte)'\\')
                                continue;
                            var e = i;
                            while (e + 1 < d.Length && (d[e] != 0 || d[e + 1] != 0))
                                e += 2;
                            moduleName = Encoding.Unicode.GetString(d, i, e - i);
                            var ps = e + 2;
                            while (ps < d.Length && d[ps] == 0)
                                ps++;
                            var pe = ps;
                            while (pe < d.Length && d[pe] != 0)
                                pe++;
                            if (pe > ps)
                                pdbName = Encoding.ASCII.GetString(d, ps, pe - ps);
                            break;
                        }
                    }

                    var dirMask = BitConverter.ToUInt16(d, 0xc);
                    var stamp = BitConverter.ToUInt32(d, 0xe);
                    var imageSize = BitConverter.ToUInt32(d, 0x12);
                    packet.AddValue("ReportKind", $"{Warden3Category(category)}: loaded module integrity descriptor (type {type}, {payload.Length} bytes, sealed)");
                    packet.AddValue("Module", moduleName ?? "(name not found)");
                    if (moduleName != null && moduleName.IndexOf("\\system32\\", StringComparison.OrdinalIgnoreCase) < 0 &&
                        moduleName.IndexOf("\\syswow64\\", StringComparison.OrdinalIgnoreCase) < 0 &&
                        moduleName.IndexOf("\\winsxs\\", StringComparison.OrdinalIgnoreCase) < 0)
                        packet.AddValue("Note", "module is outside System32/SysWOW64/WinSxS (game, overlay or injected module)");
                    if (pdbName != null)
                        packet.AddValue("Pdb", pdbName + (pdbOnFixedDrive ? " (exists on a fixed drive)" : ""));
                    packet.AddValue("PeTimeDateStamp", $"0x{stamp:X8}");
                    packet.AddValue("SizeOfImage", $"0x{imageSize:X} ({imageSize} bytes)");
                    packet.AddValue("PeCheckSum", $"0x{BitConverter.ToUInt32(d, 0x16):X8}");
                    packet.AddValue("NumberOfSections", d[0xa]);
                    packet.AddValue("MajorLinkerVersion", d[0xb]);
                    packet.AddValue("Authenticode", (dirMask & 0x10) != 0);
                    packet.AddValue("DataDirectoriesPresent", $"0x{dirMask:X4} (bit n = PE data directory n has a size)");
                    packet.AddValue("SectionLayoutHash", $"0x{BitConverter.ToUInt64(d, 0x1a):X16}");
                    packet.AddValue("DescriptorFormat", $"v{d[5]}");
                    return;
                }
            }

            if (category == 1 && payload.Length >= 10)
            {
                // scan report (type 2 on 1.13.x, 3 on 2.5.1+): FNV-1a32 of the 8 request bytes at +6, then the hashed machine values
                var js = Array.IndexOf(payload, (byte)'{');
                if (js >= 10)
                {
                    packet.AddValue("ReportKind", $"{Warden3Category(category)}: FNV-1a32 hashes of machine/OS/CPU values (type {type}, {payload.Length} bytes, sealed)");
                    packet.AddValue("ScanRequestHash", $"0x{BitConverter.ToUInt32(payload, 6):X8}");
                    var json = Encoding.ASCII.GetString(payload, js, payload.Length - js).TrimEnd('\0');
                    foreach (System.Text.RegularExpressions.Match m in System.Text.RegularExpressions.Regex.Matches(json, "\"(\\w+)\"\\s*:\\s*(\\d+)"))
                    {
                        var key = m.Groups[1].Value;
                        string desc;
                        if (!Warden3ScanKeys.TryGetValue(key, out desc))
                            desc = "?";
                        packet.AddValue(key, $"0x{uint.Parse(m.Groups[2].Value):X8}  ({desc})");
                    }

                    return;
                }
            }

            packet.AddValue("ReportKind", $"{Warden3Category(category)}: unknown layout (type {type}, {payload.Length} bytes, sealed)");
            AddRaw(packet, "ReportPayload", payload);
        }

        private static readonly System.Collections.Generic.Dictionary<string, string> Warden3ScanKeys = new System.Collections.Generic.Dictionary<string, string>
        {
            { "RGKY", "Battle.net identity registry key" }, { "CPGE", "ANSI code page" }, { "ULNG", "user language id" },
            { "SLNG", "system language id" }, { "CNME", "computer name" }, { "UNME", "user name" },
            { "UTCO", "UTC offset minutes" }, { "CARC", "CPU architecture" }, { "CLVL", "CPU level" },
            { "CREV", "CPU revision" }, { "PMEM", "physical memory MB" }, { "PSZE", "page file MB" },
            { "OVER", "OS version" }, { "CVRA", "CPUID(1) EAX" }, { "CFTC", "CPUID(1) ECX" },
            { "CFTD", "CPUID(1) EDX" }, { "CEFC", "CPUID(0x80000001) ECX" }, { "CEFD", "CPUID(0x80000001) EDX" },
            { "CBRD", "CPU brand string" }, { "CVEN", "CPU vendor" }, { "ANME", "network adapter name" },
            { "ADSC", "network adapter description" }, { "MAC", "MAC address" },
        };

        // Sub module traffic (check requests/replies, module acks): encrypted by a block cipher that lives inside the module image delivered by
        // the server, so it cannot be decoded here. Only size and the start are shown.
        private static void AddEncrypted(Packet packet, byte[] data)
        {
            packet.AddValue("PacketKind", "Encrypted module traffic (cipher is inside the downloaded Warden module, not decodable here)");
            packet.AddValue("Size", $"{data.Length} bytes");
            packet.AddValue("Start", Utilities.ByteArrayToHexString(Slice(data, 0, Math.Min(data.Length, 16))) + (data.Length > 16 ? " ..." : ""));
        }

        private static void AddRaw(Packet packet, string name, byte[] data)
        {
            const int max = 48;
            packet.AddValue(name, $"{data.Length} bytes: " + Utilities.ByteArrayToHexString(Slice(data, 0, Math.Min(data.Length, max))) + (data.Length > max ? " ..." : ""));
        }

        private static byte[] Slice(byte[] data, int offset, int count)
        {
            var r = new byte[count];
            Array.Copy(data, offset, r, 0, count);
            return r;
        }

        private static uint Rol(uint x, int n)
        {
            n &= 31;
            return n == 0 ? x : (x << n) | (x >> (32 - n));
        }

        private static uint Ror(uint x, int n)
        {
            n &= 31;
            return n == 0 ? x : (x >> n) | (x << (32 - n));
        }

        private static uint Fnv1a32(byte[] data, int offset, int count)
        {
            var h = 0x811c9dc5u;
            for (var i = 0; i < count; i++)
                h = unchecked((h ^ data[offset + i]) * 0x01000193u);
            return h;
        }

        private static uint[] GetWarden3Rc5Table()
        {
            if (_warden3Rc5Table != null)
                return _warden3Rc5Table;

            const int t = 26; // 2 * (12 + 1)
            var c = (Warden3SealKey.Length + 3) / 4;
            var l = new uint[c];
            for (var i = Warden3SealKey.Length - 1; i >= 0; i--)
                l[i / 4] = (l[i / 4] << 8) | Warden3SealKey[i];
            var s = new uint[t];
            for (var i = 0; i < t; i++)
                s[i] = unchecked(0xb7e15163u + (uint)i * 0x9e3779b9u);
            uint a = 0, b = 0;
            int ii = 0, jj = 0;
            for (var n = 0; n < 3 * Math.Max(t, c); n++)
            {
                a = s[ii] = Rol(unchecked(s[ii] + a + b), 3);
                b = l[jj] = Rol(unchecked(l[jj] + a + b), (int)(unchecked(a + b) & 31));
                ii = (ii + 1) % t;
                jj = (jj + 1) % c;
            }

            _warden3Rc5Table = s;
            return s;
        }

        // Report = 16 byte clear nonce + RC5-32/12 CBC blocks, IV = nonce[0..7].
        private static byte[] DecryptWarden3Report(byte[] rep)
        {
            var s = GetWarden3Rc5Table();
            var res = (byte[])rep.Clone();
            var s0 = BitConverter.ToUInt32(rep, 0);
            var s1 = BitConverter.ToUInt32(rep, 4);
            for (var o = 16; o + 8 <= rep.Length; o += 8)
            {
                var ca = BitConverter.ToUInt32(rep, o);
                var cb = BitConverter.ToUInt32(rep, o + 4);
                var a = ca;
                var b = cb;
                for (var i = 12; i >= 1; i--)
                {
                    b = Ror(unchecked(b - s[2 * i + 1]), (int)a) ^ a;
                    a = Ror(unchecked(a - s[2 * i]), (int)b) ^ b;
                }

                BitConverter.GetBytes(unchecked(a - s[0]) ^ s0).CopyTo(res, o);
                BitConverter.GetBytes(unchecked(b - s[1]) ^ s1).CopyTo(res, o + 4);
                s0 = ca;
                s1 = cb;
            }

            return res;
        }

        [Parser(Opcode.SMSG_CHECK_FOR_BOTS)]
        public static void HandleCheckForBots(Packet packet)
        {
            ReadCheatCheckDecryptionBlock(packet);
        }

        [Parser(Opcode.CMSG_BOT_DETECTED)]
        public static void HandleBotDetected(Packet packet)
        {
            packet.ReadBool("Glider 1 Detected");
            packet.ReadBool("Glider 2 Detected");
            packet.ReadBool("Inner Space Detected");
            packet.ReadBytes(20); // Hash
        }

        [Parser(Opcode.CMSG_BOT_DETECTED2)]
        public static void HandleBotDetected2(Packet packet)
        {
            packet.ReadInt32("Unk Int32");
        }

        public static void ReadCheatCheckDecryptionBlock(Packet packet)
        {
            packet.ReadBytes("ARC4 Key", 16);
        }
    }
}
