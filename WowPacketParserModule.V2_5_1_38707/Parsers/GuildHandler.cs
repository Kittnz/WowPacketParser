using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V2_5_1_38707.Parsers
{
    public static class GuildHandler
    {
        [Parser(Opcode.SMSG_QUERY_GUILD_INFO_RESPONSE)]
        public static void HandleGuildQueryResponse(Packet packet)
        {
            WowPacketParserModule.V8_0_1_27101.Parsers.GuildHandler.HandleGuildQueryResponse(packet);
        }

        [Parser(Opcode.SMSG_GUILD_ROSTER)]
        public static void HandleGuildRoster(Packet packet)
        {
            if (ClientVersion.AddedInClassicVersion(1, 14, 3, 2, 5, 4))
            {
                WowPacketParserModule.V9_0_1_36216.Parsers.GuildHandler.HandleGuildRoster(packet);
                return;
            }

            WowPacketParserModule.V8_0_1_27101.Parsers.GuildHandler.HandleGuildRoster(packet);
        }


        [Parser(Opcode.SMSG_GUILD_BANK_QUERY_RESULTS)]
        public static void HandleGuildBankQueryResults(Packet packet)
        {
            if (ClientVersion.RemovedInVersion(ClientVersionBuild.V2_5_2_39926))
            {
                WowPacketParserModule.V8_0_1_27101.Parsers.GuildHandler.HandleGuildBankQueryResults(packet);
                return;
            }

            // 2.5.2.40011+ (sniff-verified on 40011 and 41812): FullUpdate bit moved in front of the tab list and the SocketEnchant count is gone
            packet.ReadUInt64("Money");
            packet.ReadInt32("Tab");
            packet.ReadInt32("WithdrawalsRemaining");

            var tabInfoCount = packet.ReadInt32("TabInfoCount");
            var itemInfoCount = packet.ReadInt32("ItemInfoCount");

            packet.ResetBitReader();
            packet.ReadBit("FullUpdate");

            for (int i = 0; i < tabInfoCount; i++)
            {
                packet.ReadInt32("TabIndex", i);

                packet.ResetBitReader();
                var nameLen = packet.ReadBits(7);
                var iconLen = packet.ReadBits(9);

                packet.ReadWoWString("Name", nameLen, i);
                packet.ReadWoWString("Icon", iconLen, i);
            }

            for (int i = 0; i < itemInfoCount; i++)
            {
                packet.ReadInt32("Slot", i);
                packet.ReadInt32("Count", i);
                packet.ReadInt32("EnchantmentID", i);
                packet.ReadInt32("Charges", i);
                packet.ReadInt32("OnUseEnchantmentID", i);
                packet.ReadInt32("Flags", i);

                Substructures.ItemHandler.ReadItemInstance(packet, i, "ItemInstance");

                packet.ResetBitReader();
                packet.ReadBit("Locked", i);
            }
        }

        [Parser(Opcode.CMSG_PETITION_BUY)]
        public static void HandlePetitionBuy(Packet packet)
        {
            int length = (int)packet.ReadBits(7);

            packet.ReadPackedGuid128("Unit");
            packet.ReadUInt32("Unused910");
            packet.ReadWoWString("Name", length);
        }

        [Parser(Opcode.CMSG_OFFER_PETITION)]
        public static void HandlePetitionOffer(Packet packet)
        {
            packet.ReadUInt32("Junk"); // uninitialized variable
            packet.ReadPackedGuid128("Item GUID");
            packet.ReadPackedGuid128("Target GUID");
        }

        [Parser(Opcode.CMSG_TURN_IN_PETITION)]
        public static void HandlePetitionTurnIn(Packet packet)
        {
            packet.ReadPackedGuid128("Petition GUID");
            if (packet.CanRead())
            {
                packet.ReadUInt32("Background Color");
                packet.ReadInt32("Emblem Style");
                packet.ReadUInt32("Emblem Color");
                packet.ReadInt32("Emblem Border Style");
                packet.ReadUInt32("Emblem Border Color");
            }
        }

        [Parser(Opcode.SMSG_PETITION_SHOW_LIST)]
        public static void HandlePetitionShowList(Packet packet)
        {
            packet.ReadPackedGuid128("GUID");
            var counter = packet.ReadUInt32("Count");
            for (var i = 0; i < counter; i++)
            {
                packet.ReadUInt32("Index", i);
                packet.ReadUInt32("Charter Cost", i);
                packet.ReadUInt32("Charter Entry", i);
                packet.ReadUInt32("Is Arena", i);
                packet.ReadUInt32("Required Signatures", i);
            }
        }
    }
}
