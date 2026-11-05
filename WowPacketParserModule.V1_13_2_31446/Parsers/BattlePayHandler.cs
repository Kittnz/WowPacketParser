using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V1_13_2_31446.Parsers
{
    public static class BattlePayHandler
    {
        // 2.5.2+ and 3.4.1 (sniff-verified on 3.4.1.47612) use the extended battle pay layouts
        private static bool IsExtendedLayout()
        {
            return ClientVersion.IsBurningCrusadeClassicClientVersionBuild(ClientVersion.Build) || ClientVersion.IsWrathOfTheLichKingClassicClientVersionBuild(ClientVersion.Build);
        }

        private static void ReadBattlepayDisplayInfo(Packet packet, params object[] idx)
        {
            if (IsExtendedLayout())
            {
                // 2.5.2.40260 sniffs: 62 bits (two further 13 bit string lengths (Name4/Name5)), flush, then up to six ints and the strings
                var hasCreature = packet.ReadBit("HasCreatureDisplayInfoID", idx);
                var hasFileData = packet.ReadBit("HasFileDataID", idx);
                var l1 = packet.ReadBits(10);
                var l2 = packet.ReadBits(10);
                var l3 = packet.ReadBits(13);
                var l4 = packet.ReadBits("Name4Length", 13, idx);
                var l5 = packet.ReadBits("Name5Length", 13, idx);
                var flags = packet.ReadBit("HasFlags", idx);
                packet.ResetBitReader();
                for (var i = 0; i < 4; ++i)
                    packet.ReadInt32("Unk", idx, i);
                var isWrath = ClientVersion.IsWrathOfTheLichKingClassicClientVersionBuild(ClientVersion.Build);
                // 2.5.1-2.5.2.41510 (3115 byte product lists): no creature int even with the bit set; 2.5.3+ and 3.4.1.47612 sniffs: present
                if (hasCreature && (isWrath || ClientVersion.Build >= ClientVersionBuild.V2_5_3_41750))
                    packet.ReadInt32("CreatureDisplayInfoID", idx);
                if (hasFileData) // sniffs: FileDataID int follows the creature int
                    packet.ReadInt32("FileDataID", idx);
                packet.ReadInt32("Unk", idx, 4);
                packet.ReadWoWString("Name1", l1, idx);
                packet.ReadWoWString("Name2", l2, idx);
                packet.ReadWoWString("Name3", l3, idx);
                packet.ReadWoWString("Name4", (int)l4, idx);
                packet.ReadWoWString("Name5", (int)l5, idx);
                if (flags)
                    packet.ReadInt32("Flags", idx);
                if (l4 != 0)
                    packet.ReadInt32("UnkAfterName4", idx); // only seen when Name4 is present (one sample)
                return;
            }

            var hasCreatureDisplayInfoId = packet.ReadBit("HasCreatureDisplayInfoID", idx);
            var hasFileDataId = packet.ReadBit("HasFileDataID", idx);
            var len1 = packet.ReadBits(10);
            var len2 = packet.ReadBits(10);
            var len3 = packet.ReadBits(13);
            packet.ReadBits("UnkBits", 13, idx);
            var hasFlags = packet.ReadBit("HasFlags", idx);

            if (hasCreatureDisplayInfoId)
                packet.ReadInt32("CreatureDisplayInfoID", idx);

            if (hasFileDataId)
                packet.ReadInt32("FileDataID", idx);

            packet.ReadInt32("Unk", idx);

            packet.ReadWoWString("Name1", len1, idx);
            packet.ReadWoWString("Name2", len2, idx);
            packet.ReadWoWString("Name3", len3, idx);

            if (hasFlags)
                packet.ReadInt32("Flags", idx);
        }

        private static void ReadBattlePayProductInfo(Packet packet, params object[] idx)
        {
            packet.ReadInt32("ProductID", idx);
            packet.ReadInt64("NormalPriceFixedPoint", idx);
            packet.ReadInt64("CurrentPriceFixedPoint", idx);

            var count = packet.ReadInt32("ProductIDsCount", idx);
            packet.ReadInt32("Unk1", idx);
            packet.ReadInt32("Unk2", idx);
            if (IsExtendedLayout())
            {
                // 2.5.x sniffs: two more ints before the product id list
                packet.ReadInt32("Unk3", idx);
                packet.ReadInt32("Unk4", idx);
            }
            for (var i = 0; i < count; ++i)
                packet.ReadInt32("ProductIDs", idx, i);

            packet.ResetBitReader();
            packet.ReadBits("UnkBits", 7, idx);
            var hasDisplayInfo = packet.ReadBit("HasBattlepayDisplayInfo", idx);
            packet.ResetBitReader();
            if (hasDisplayInfo)
                ReadBattlepayDisplayInfo(packet, idx);
        }

        private static void ReadBattlePayProduct(Packet packet, params object[] idx)
        {
            packet.ReadInt32("ProductID", idx);
            packet.ReadInt32("Unk1", idx);
            if (IsExtendedLayout())
            {
                // 2.5.2.40260 sniffs: nine ints and a byte, then an 8 bit name length plus 16 more bits and the name
                for (var i = 0; i < 9; ++i)
                    packet.ReadInt32("Unk", idx, i);
                packet.ReadByte("UnkByte", idx);
                packet.ResetBitReader();
                var nameLen = packet.ReadBits(8);
                packet.ReadBits("UnkBits", 16, idx);
                packet.ReadWoWString("Name", nameLen, idx);
                return;
            }

            for (var i = 0; i < 6; ++i)
                packet.ReadInt32("Unk", idx, i);
        }

        [Parser(Opcode.SMSG_BATTLE_PAY_GET_PRODUCT_LIST_RESPONSE)]
        public static void HandleBattlePayGetProductListResponse(Packet packet)
        {
            packet.ReadUInt32("Result");
            packet.ReadUInt32("CurrencyID");

            var productInfoCount = packet.ReadUInt32("BattlePayProductInfoCount");
            var productCount = packet.ReadUInt32("BattlePayProductCount");
            var groupCount = packet.ReadUInt32("BattlePayProductGroupCount");
            var shopEntryCount = packet.ReadUInt32("BattlePayShopEntryCount");

            for (var i = 0; i < productInfoCount; ++i)
                ReadBattlePayProductInfo(packet, "ProductInfo", i);

            for (var i = 0; i < productCount; ++i)
                ReadBattlePayProduct(packet, "Product", i);

            for (var i = 0; i < groupCount; ++i)
            {
                packet.ReadInt32("GroupID", "Group", i);
                packet.ReadInt32("IconFileDataID", "Group", i);
                packet.ReadByte("DisplayType", "Group", i);
                packet.ReadInt32("Ordering", "Group", i);
                packet.ReadInt32("Unk", "Group", i);

                packet.ResetBitReader();
                var nameLen = packet.ReadBits(8);
                var descBits = packet.ReadBits("UnkBits", 23, "Group", i);
                packet.ReadBit("UnkBit", "Group", i);
                packet.ReadWoWString("Name", nameLen, "Group", i);
                if (descBits != 0 && IsExtendedLayout())
                {
                    // 2.5.2.40260 sniffs: the 23 bits are half the length of a trailing description (60 chars + NUL for value 30); only one sample
                    packet.ReadWoWString("Description", (int)descBits * 2, "Group", i);
                    packet.ReadByte("DescriptionTerminator", "Group", i);
                }
            }

            for (var i = 0; i < shopEntryCount; ++i)
            {
                packet.ReadUInt32("EntryID", "ShopEntry", i);
                packet.ReadUInt32("GroupID", "ShopEntry", i);
                packet.ReadUInt32("ProductID", "ShopEntry", i);
                packet.ReadInt32("Ordering", "ShopEntry", i);
                packet.ReadInt32("Flags", "ShopEntry", i);
                packet.ReadByte("BannerType", "ShopEntry", i);

                packet.ResetBitReader();
                var hasDisplayInfo = packet.ReadBit("HasBattlepayDisplayInfo", "ShopEntry", i);
                packet.ResetBitReader();
                if (hasDisplayInfo)
                    ReadBattlepayDisplayInfo(packet, "ShopEntry", i);
            }
        }

        [Parser(Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE)]
        public static void HandleBattlePayGetPurchaseListResponse(Packet packet)
        {
            packet.ReadUInt32("Result");
            var count = packet.ReadUInt32("BattlePayPurchaseCount");
            for (var i = 0; i < count; ++i)
            {
                packet.ReadInt64("PurchaseID", i);
                packet.ReadInt32("Status", i);
                packet.ReadInt32("ResultCode", i);
                packet.ReadInt32("ProductID", i);
                if (IsExtendedLayout() && ClientVersion.AddedInVersion(ClientVersionBuild.V2_5_2_39570))
                {
                    // 2.5.2.40260 sniffs: four ints then a unix time precede the wallet name bits
                    packet.ReadInt32("Unk1", i);
                    packet.ReadInt32("Unk2", i);
                    packet.ReadInt32("Unk3", i);
                    packet.ReadInt32("Unk4", i);
                    packet.ReadTime("Time", i);
                    if (ClientVersion.IsWrathOfTheLichKingClassicClientVersionBuild(ClientVersion.Build))
                        packet.ReadInt32("Unk5", i); // 3.4.1.47612 sniffs: 5 bytes between the time and the next entry
                }
                packet.ResetBitReader();
                var len = packet.ReadBits(8);
                packet.ReadWoWString("WalletName", len, i);
            }
        }

        [Parser(Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE)]
        public static void HandleBattlePayGetDistributionListResponse(Packet packet)
        {
            packet.ReadUInt32("Result");
            var count = packet.ReadBits("BattlePayDistributionObjectCount", 11);
            if (count != 0)
                packet.ReadToEnd();
        }
    }
}
