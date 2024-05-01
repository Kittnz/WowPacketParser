using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class AuctionHouseHandler
    {

        [Parser(Opcode.SMSG_AUCTION_HELLO_RESPONSE)]
        public static void HandleServerAuctionHello(Packet packet)
        {
            packet.ReadPackedGuid128("Guid");
            packet.ReadUInt32("DeliveryDelay"); // Unsure
            packet.ReadInt32("AuctionHouseID"); // Unsure
            packet.ReadBit("OpenForBusiness");

            CoreParsers.NpcHandler.LastGossipOption.Reset();
            CoreParsers.NpcHandler.TempGossipOptionPOI.Reset();
        }

        [Parser(Opcode.CMSG_AUCTION_LIST_OWNED_ITEMS)]
        public static void HandleAuctionListOwnerItems(Packet packet)
        {
            packet.ReadPackedGuid128("Auctioneer");
            packet.ReadUInt32("Offset");
            bool hasAddonInfo = packet.ReadBit("HasAddonInfo");

            if (hasAddonInfo)
                V8_0_1_27101.Parsers.AddonHandler.ReadAddOnInfo(packet);
        }

        [Parser(Opcode.CMSG_AUCTION_LIST_ITEMS)]
        public static void HandleAuctionListItems(Packet packet)
        {
            packet.ReadPackedGuid128("Auctioneer");
            packet.ReadUInt32("Offset");

            packet.ReadByte("MinLevel");
            packet.ReadByte("MaxLevel");
            packet.ReadInt32E<ItemQuality>("Quality");
            var sort = packet.ReadByte("SortCount");
            var knownPetsCount = packet.ReadUInt32("KnownPetsCount");
            packet.ReadSByte("MaxPetLevel");

            for (int i = 0; i < knownPetsCount; ++i)
                packet.ReadByte("KnownPets", i);

            bool hasAddonInfo = packet.ReadBit("HasAddonInfo");

            var nameLength = packet.ReadBits("NameLength", 8);
            packet.ReadWoWString("Name", nameLength);

            var classFiltersCount = packet.ReadBits("ClassFiltersCount", 3);

            packet.ReadBit("OnlyUsable");
            packet.ReadBit("ExactMatch");

            packet.ResetBitReader();

            if (hasAddonInfo && ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47720))
            {
                packet.ReadByte("Unknown");
                V8_0_1_27101.Parsers.AddonHandler.ReadAddOnInfo(packet);
            }

            for (int i = 0; i < classFiltersCount; ++i)
            {
                packet.ReadInt32E<ItemClass>("ItemClass", "ClassFilters", i);

                var subClassFiltersCount = packet.ReadBits("SubClassFiltersCount", 5, "ClassFilters", i);
                for (int j = 0; j < subClassFiltersCount; ++j)
                {
                    packet.ReadInt32("ItemSubclass", "ClassFilters", i, "SubClassFilters", j);
                    packet.ReadUInt32("InvTypeMask", "ClassFilters", i, "SubClassFilters", j);
                }
            }

            var size = packet.ReadInt32("DataSize");
            var data = packet.ReadBytes(size);
            var sorts = new Packet(data, packet.Opcode, packet.Time, packet.Direction, packet.Number, packet.Writer, packet.FileName);
            for (var i = 0; i < sort; ++i)
            {
                sorts.ReadByte("Type", i);
                sorts.ReadByte("Direction", i);
            }
        }

        [Parser(Opcode.CMSG_AUCTION_SELL_ITEM)]
        public static void HandleAuctionSellItem(Packet packet)
        {
            packet.ReadPackedGuid128("Auctioneer");
            packet.ReadInt64("BidPrice");
            packet.ReadInt64("BuyoutPrice");
            packet.ReadInt32("RunTime");
            bool hasAddonInfo = packet.ReadBit("HasAddonInfo");

            var count = packet.ReadBits("ItemsCount", 6);
            packet.ResetBitReader();

            if (hasAddonInfo)
                V8_0_1_27101.Parsers.AddonHandler.ReadAddOnInfo(packet);

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47720))
                packet.ReadUInt16("Unknown");

            for (var i = 0; i < count; ++i)
            {
                packet.ReadPackedGuid128("Guid", i);
                packet.ReadInt32("UseCount");
            }
        }
    }
}
