using System;
using System.Globalization;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using CoreParsers = WowPacketParser.Parsing.Parsers;


namespace WowPacketParserModule.V9_0_1_36216.Parsers
{
    public static class NpcHandler
    {
        [Parser(Opcode.SMSG_RUNEFORGE_LEGENDARY_CRAFTING_OPEN_NPC)]
        public static void HandleRuneforgeLegendaryCraftingOpenNpc(Packet packet)
        {
            packet.ReadPackedGuid128("GUID");
            packet.ReadBit("IsUpgrade"); // Correct?

            CoreParsers.NpcHandler.LastGossipOption.Reset();
            CoreParsers.NpcHandler.TempGossipOptionPOI.Reset();
        }

        [Parser(Opcode.SMSG_GOSSIP_POI)]
        public static void HandleGossipPoi(Packet packet)
        {
            PointsOfInterest gossipPOI = new PointsOfInterest();

            gossipPOI.ID = packet.ReadInt32("ID");

            if (ClientVersion.AddedInVersion(10, 0, 7, 1, 15, 0, 3, 4, 3))
                gossipPOI.Flags = (uint)packet.ReadInt32("Flags");

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V9_1_0_39185))
            {
                Vector3 pos = packet.ReadVector3("Coordinates");
                gossipPOI.PositionX = pos.X;
                gossipPOI.PositionY = pos.Y;
                gossipPOI.PositionZ = pos.Z;
            }
            else
            {
                Vector2 pos = packet.ReadVector2("Coordinates");
                gossipPOI.PositionX = pos.X;
                gossipPOI.PositionY = pos.Y;
            }

            gossipPOI.Icon = packet.ReadInt32E<GossipPOIIcon>("Icon");
            gossipPOI.Importance = (uint)packet.ReadInt32("Importance");

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V9_0_5_37503))
                gossipPOI.WMOGroupID = packet.ReadInt32("WMOGroupID");

            packet.ResetBitReader();
            if (ClientVersion.RemovedInVersion(10, 0, 7, 1, 15, 0, 3, 4, 3))
                gossipPOI.Flags = packet.ReadBits("Flags", 14);
            uint bit84 = packet.ReadBits(6);
            gossipPOI.Name = packet.ReadWoWString("Name", bit84);

            var lastGossipOption = CoreParsers.NpcHandler.LastGossipOption;
            var tempGossipOptionPOI = CoreParsers.NpcHandler.TempGossipOptionPOI;

            lastGossipOption.ActionPoiId = gossipPOI.ID;
            tempGossipOptionPOI.ActionPoiId = gossipPOI.ID;

            if (ClientLocale.PacketLocale != LocaleConstant.enUS)
            {
                PointsOfInterestLocale localesPoi = new PointsOfInterestLocale
                {
                    ID = gossipPOI.ID.ToString(),
                    Name = gossipPOI.Name,
                };

                Storage.LocalesPointsOfInterest.Add(localesPoi, packet.TimeSpan);
            }
            else
            {
                Storage.GossipPOIs.Add(gossipPOI, packet.TimeSpan);
            }

            if (tempGossipOptionPOI.HasSelection)
            {
                if ((packet.TimeSpan - tempGossipOptionPOI.TimeSpan).Duration() <= TimeSpan.FromMilliseconds(2500))
                {
                    if (tempGossipOptionPOI.ActionMenuId != null)
                    {
                        Storage.GossipMenuOptionActions.Add(new GossipMenuOptionAction { MenuId = tempGossipOptionPOI.MenuId, OptionIndex = tempGossipOptionPOI.OptionIndex, ActionMenuId = tempGossipOptionPOI.ActionMenuId, ActionPoiId = gossipPOI.ID }, packet.TimeSpan);
                        //clear temp
                        tempGossipOptionPOI.Reset();
                    }
                }
                else
                {
                    lastGossipOption.Reset();
                    tempGossipOptionPOI.Reset();
                }
            }
        }
		
        [Parser(Opcode.SMSG_CHROMIE_TIME_OPEN_NPC)]
        public static void HandleChromieTimeOpenNpc(Packet packet)
        {
            packet.ReadPackedGuid128("GUID");
        }

        [Parser(Opcode.CMSG_CHROMIE_TIME_SELECT_EXPANSION)]
        public static void HandleChromieTimeSelectExpansion(Packet packet)
        {
            packet.ReadPackedGuid128("GUID");
            packet.ReadUInt32("Expansion");
        }

        [Parser(Opcode.SMSG_COVENANT_PREVIEW_OPEN_NPC)]
        public static void HandleGarrisonCovenantPreviewOpenNpc(Packet packet)
        {
            packet.ReadPackedGuid128("NpcGUID");
            packet.ReadInt32("CovenantID");
        }
		
        [Parser(Opcode.SMSG_ADVENTURE_MAP_OPEN_NPC)]
        public static void HandleAdventureMapOpenNpc(Packet packet)
        {
            packet.ReadPackedGuid128("NpcGUID");
            packet.ReadInt32("UiMapID");
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_GOSSIP_MESSAGE, ClientVersionBuild.V9_2_5_43903)]
        public static void HandleNpcGossip(Packet packet)
        {
            GossipMenu gossip = new GossipMenu();

            WowGuid guid = packet.ReadPackedGuid128("GossipGUID");

            gossip.ObjectType = guid.GetObjectType();
            gossip.ObjectEntry = guid.GetEntry();

            int menuId = packet.ReadInt32("GossipID");
            gossip.Entry = (uint)menuId;

            packet.ReadInt32("FriendshipFactionID");

            gossip.BroadcastTextID = (uint)packet.ReadInt32("BroadcastTextID");

            int optionCount = packet.ReadInt32("GossipOptionsCount");
            int questCount = packet.ReadInt32("GossipQuestsCount");

            for (int i = 0; i < optionCount; ++i)
                V6_0_2_19033.Parsers.NpcHandler.ReadGossipOptionsData((uint)menuId, packet, i, "GossipOptions");

            for (int i = 0; i < questCount; ++i)
                V7_0_3_22248.Parsers.NpcHandler.ReadGossipQuestTextData(packet, i, "GossipQuests");

            Storage.StoreCreatureGossip(guid, (uint)menuId, packet);
            Storage.Gossips.Add(gossip, packet.TimeSpan);
            CoreParsers.NpcHandler.CanBeDefaultGossipMenu = false;
            var lastGossipOption = CoreParsers.NpcHandler.LastGossipOption;
            var tempGossipOptionPOI = CoreParsers.NpcHandler.TempGossipOptionPOI;

            if (lastGossipOption.HasSelection)
            {
                if ((packet.TimeSpan - lastGossipOption.TimeSpan).Duration() <= TimeSpan.FromMilliseconds(2500))
                {
                    Storage.GossipMenuOptionActions.Add(new GossipMenuOptionAction { MenuId = lastGossipOption.MenuId, OptionIndex = lastGossipOption.OptionIndex, ActionMenuId = gossip.Entry, ActionPoiId = lastGossipOption.ActionPoiId }, packet.TimeSpan);

                    //keep temp data (for case SMSG_GOSSIP_POI is delayed)
                    tempGossipOptionPOI.Guid = lastGossipOption.Guid;
                    tempGossipOptionPOI.MenuId = lastGossipOption.MenuId;
                    tempGossipOptionPOI.OptionIndex = lastGossipOption.OptionIndex;
                    tempGossipOptionPOI.ActionMenuId = gossip.Entry;
                    tempGossipOptionPOI.TimeSpan = lastGossipOption.TimeSpan;

                    // clear lastgossip so no faulty linkings appear
                    lastGossipOption.Reset();
                }
                else
                {
                    lastGossipOption.Reset();
                    tempGossipOptionPOI.Reset();

                }
            }

            packet.AddSniffData(StoreNameType.Gossip, menuId, guid.GetEntry().ToString(CultureInfo.InvariantCulture));
        }

        [Parser(Opcode.SMSG_VENDOR_INVENTORY)]
        public static void HandleVendorInventory(Packet packet)
        {
            uint entry = packet.ReadPackedGuid128("VendorGUID").GetEntry();
            packet.ReadByte("Reason");
            int count = packet.ReadInt32("VendorItems");

            for (int i = 0; i < count; ++i)
            {
                NpcVendor vendor = new NpcVendor
                {
                    Entry = entry,
                    Slot = packet.ReadInt32("Muid", i),
                    Type = (uint)packet.ReadInt32("Type", i)
                };

                int maxCount = packet.ReadInt32("Quantity", i);
                packet.ReadInt64("Price", i);
                packet.ReadInt32("Durability", i);
                int buyCount = packet.ReadInt32("StackCount", i);
                vendor.ExtendedCost = packet.ReadUInt32("ExtendedCostID", i);
                vendor.PlayerConditionID = packet.ReadUInt32("PlayerConditionFailed", i);

                vendor.Item = Substructures.ItemHandler.ReadItemInstance(packet, i).ItemID;
                packet.ResetBitReader();
                packet.ReadBit("Locked", i);
                vendor.IgnoreFiltering = packet.ReadBit("DoNotFilterOnVendor", i);
                packet.ReadBit("Refundable", i);

                vendor.MaxCount = maxCount == -1 ? 0 : (uint)maxCount; // TDB
                if (vendor.Type == 2)
                    vendor.MaxCount = (uint)buyCount;

                Storage.NpcVendors.Add(vendor, packet.TimeSpan);
            }

            CoreParsers.NpcHandler.LastGossipOption.Reset();
            CoreParsers.NpcHandler.TempGossipOptionPOI.Reset();
        }
    }
}
