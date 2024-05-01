using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class ItemHandler
    {
        [Parser(Opcode.CMSG_USE_ITEM)]
        public static void HandleUseItem(Packet packet)
        {
            packet.ReadByte("PackSlot");
            packet.ReadByte("Slot");
            WowGuid guid = packet.ReadPackedGuid128("CastItem");

            if(Storage.Objects.ContainsKey(guid))
            {
                ItemClientUse newItemuse = new ItemClientUse
                {
                    Entry = (uint)Storage.Objects[guid].Item1.ObjectData.EntryID,
                    UnixTimeMs = (ulong)packet.UnixTimeMs,
                };
                Storage.ItemClientUseTimes.Add(newItemuse, packet.TimeSpan);
            }

            SpellHandler.ReadSpellCastRequest(packet, "Cast");
        }

        [Parser(Opcode.CMSG_USE_TOY)]
        public static void HandleUseToy(Packet packet)
        {
            SpellHandler.ReadSpellCastRequest(packet, "Cast");
        }
    }
}
