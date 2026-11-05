using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class SessionHandler
    {
        // 3.4.0.44930 .. 3.4.1.47966 sniffs all carry a 64 byte RSA encrypted key (65 byte packet); 256 byte key assumed from 3.4.2 (unsampled)
        [Parser(Opcode.SMSG_ENTER_ENCRYPTED_MODE, ClientVersionBuild.V3_4_0_44463)]
        public static void HandleEnterEncryptedMode(Packet packet)
        {
            packet.ReadBytes("EncryptionKey (RSA encrypted)", (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_49311) && ClientVersion.Build != ClientVersionBuild.V3_4_1_49345 && ClientVersion.Build != ClientVersionBuild.V3_4_1_49822 && ClientVersion.Build != ClientVersionBuild.V3_4_1_49936) ? 256 : 64); // 3.4.1 live builds 49345+ numerically exceed 3.4.2.49311 but still use the 64 byte key (sniff-verified)
            packet.ResetBitReader();
            packet.ReadBit("Enabled");
        }

        // 3.4.1.47800 sniffs: same layout as the other client chat messages (int Language, 11 bit text length, text); raid/officer/raid warning have no V8+ handler
        [Parser(Opcode.CMSG_CHAT_MESSAGE_RAID)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_RAID_WARNING)]
        [Parser(Opcode.CMSG_CHAT_MESSAGE_OFFICER)]
        public static void HandleClientChatMessageGroup(Packet packet)
        {
            V8_0_1_27101.Parsers.ChannelHandler.HandleClientChatMessage(packet);
        }

        [Parser(Opcode.SMSG_SET_TIME_ZONE_INFORMATION)]
        public static void HandleSetTimeZoneInformation(Packet packet)
        {
            var len1 = packet.ReadBits(7);
            var len2 = packet.ReadBits(7);
            var len3 = packet.ReadBits(7);

            packet.ReadWoWString("ServerTimeTZ", len1);
            packet.ReadWoWString("GameTimeTZ", len2);
            packet.ReadWoWString("ServerRegionalTZ", len3);
        }

        [Parser(Opcode.CMSG_PLAYER_LOGIN, ClientVersionBuild.V3_4_3_51505)]
        public static void HandlePlayerLogin(Packet packet)
        {
            Storage.CurrentActivePlayer = packet.ReadPackedGuid128("Guid");
            packet.ReadSingle("FarClip");
        }
    }
}
