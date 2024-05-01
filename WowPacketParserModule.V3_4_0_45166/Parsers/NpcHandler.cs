using System;
using System.Collections.Generic;
using System.Globalization;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.SQL;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class NpcHandler
    {
        [Parser(Opcode.SMSG_GOSSIP_POI)]
        public static void HandleGossipPoi(Packet packet)
        {
            PointsOfInterest gossipPOI = new PointsOfInterest();

            gossipPOI.ID = packet.ReadInt32("ID");

            if (ClientVersion.AddedInVersion(10, 0, 7, 1, 15, 0, 3, 4, 3))
                gossipPOI.Flags = (uint)packet.ReadInt32("Flags");

            Vector3 pos = packet.ReadVector3("Coordinates");
            gossipPOI.PositionX = pos.X;
            gossipPOI.PositionY = pos.Y;
            gossipPOI.PositionZ = pos.Z;

            gossipPOI.Icon = packet.ReadInt32E<GossipPOIIcon>("Icon");
            gossipPOI.Importance = (uint)packet.ReadInt32("Importance");
            packet.ReadInt32("Unknown905");

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

        public static void ReadGossipOptionsData(uint menuId, WowGuid npcGuid, Packet packet, params object[] idx)
        {
            GossipMenuOption gossipOption = new GossipMenuOption
            {
                MenuId = menuId
            };
            GossipMenuOptionBox gossipMenuOptionBox = new GossipMenuOptionBox
            {
                MenuId = menuId
            };

            if (ClientVersion.RemovedInVersion(ClientVersionBuild.V3_4_1_47014))
                gossipOption.OptionIndex = gossipMenuOptionBox.OptionIndex = (uint)packet.ReadInt32("OptionID", idx);
            else
                gossipOption.OptionIndex = gossipMenuOptionBox.OptionIndex = (uint)packet.ReadInt32("GossipOptionID", idx);

            gossipOption.OptionIcon = (GossipOptionIcon?)packet.ReadByte("OptionNPC", idx);
            gossipMenuOptionBox.BoxCoded = packet.ReadByte("OptionFlags", idx) != 0;
            gossipMenuOptionBox.BoxMoney = (uint)packet.ReadInt32("OptionCost", idx);
            gossipOption.Language = packet.ReadUInt32E<Language>("Language", idx);

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
            {
                packet.ReadInt32("Flags", idx);
                gossipOption.OptionIndex = (uint)packet.ReadInt32("OrderIndex", idx);
            }

            packet.ResetBitReader();
            uint textLen = packet.ReadBits(12);
            uint confirmLen = packet.ReadBits(12);
            bool hasSpellId = false;
            bool hasOverrideIconId = false;
            packet.ReadBits("Status", 2, idx);
            hasSpellId = packet.ReadBit();
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
                hasOverrideIconId = packet.ReadBit();

            uint rewardsCount = packet.ReadUInt32();
            for (uint i = 0; i < rewardsCount; ++i)
            {
                packet.ResetBitReader();
                packet.ReadBits("Type", 1, idx, "TreasureItem", i);
                packet.ReadInt32("ID", idx, "TreasureItem", i);
                packet.ReadInt32("Quantity", idx, "TreasureItem", i);
            }

            gossipOption.OptionText = packet.ReadWoWString("Text", textLen, idx);
            gossipMenuOptionBox.BoxText = packet.ReadWoWString("Confirm", confirmLen, idx);

            if (hasSpellId)
                packet.ReadInt32("SpellID", idx);

            if (hasOverrideIconId)
                packet.ReadInt32("OverrideIconID", idx);

            List<int> boxTextList;
            List<int> optionTextList;

            if (gossipMenuOptionBox.BoxText != string.Empty && SQLDatabase.BroadcastTexts.TryGetValue(gossipMenuOptionBox.BoxText, out boxTextList))
            {
                if (boxTextList.Count == 1)
                    gossipMenuOptionBox.BoxBroadcastTextId = boxTextList[0];
                else
                {
                    gossipMenuOptionBox.BroadcastTextIdHelper += "BoxBroadcastTextID: ";
                    gossipMenuOptionBox.BroadcastTextIdHelper += string.Join(" - ", boxTextList);
                }
            }
            else
                gossipMenuOptionBox.BoxBroadcastTextId = 0;

            if (gossipOption.OptionText != string.Empty && SQLDatabase.BroadcastTexts.TryGetValue(gossipOption.OptionText, out optionTextList))
            {
                if (optionTextList.Count == 1)
                    gossipOption.OptionBroadcastTextId = optionTextList[0];
                else
                {
                    gossipOption.BroadcastTextIDHelper += "OptionBroadcastTextID: ";
                    gossipOption.BroadcastTextIDHelper += string.Join(" - ", optionTextList);
                }
            }
            else
                gossipOption.OptionBroadcastTextId = 0;


            Storage.GossipMenuOptions.Add(gossipOption, packet.TimeSpan);
            if (!gossipMenuOptionBox.IsEmpty)
                Storage.GossipMenuOptionBoxes.Add(gossipMenuOptionBox, packet.TimeSpan);
        }

        public static void ReadGossipQuestTextData(Packet packet, params object[] idx)
        {
            packet.ReadInt32("QuestID", idx);
            packet.ReadInt32("ContentTuningID", idx);
            packet.ReadInt32("QuestType", idx);
            packet.ReadInt32("QuestLevel", idx);
            packet.ReadInt32("QuestMaxScalingLevel", idx);

            for (int j = 0; j < 2; ++j)
                packet.ReadInt32("QuestFlags", idx, j);

            packet.ResetBitReader();

            packet.ReadBit("Repeatable", idx);

            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_3_51505)) // assumption
                packet.ReadBit("Important", idx);

            uint questTitleLen = packet.ReadBits(9);
            packet.ReadWoWString("QuestTitle", questTitleLen, idx);
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_GOSSIP_MESSAGE)]
        public static void HandleNpcGossip(Packet packet)
        {
            GossipMenu gossip = new GossipMenu();

            WowGuid guid = packet.ReadPackedGuid128("GossipGUID");

            gossip.ObjectType = guid.GetObjectType();
            gossip.ObjectEntry = guid.GetEntry();

            int menuId = packet.ReadInt32("GossipID");
            gossip.Entry = (uint)menuId;

            packet.ReadInt32("FriendshipFactionID");

            if (ClientVersion.RemovedInVersion(ClientVersionBuild.V3_4_1_47014))
                gossip.TextID = (uint)packet.ReadInt32("TextID");

            int optionsCount = packet.ReadInt32("GossipOptionsCount");
            int questsCount = packet.ReadInt32("GossipQuestsCount");

            bool hasNpcTextID = false;
            bool hasBroadcastTextID = false;
            if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_1_47014))
            {
                hasNpcTextID = packet.ReadBit("HasNpcTextID");
                hasBroadcastTextID = packet.ReadBit("HasBroadcastTextID");
            }

            for (int i = 0; i < optionsCount; ++i)
                ReadGossipOptionsData((uint)menuId, guid, packet, i, "GossipOptions");

            if (hasNpcTextID)
                gossip.TextID = (uint)packet.ReadInt32("TextID");

            if (hasBroadcastTextID)
                gossip.BroadcastTextID = (uint)packet.ReadInt32("BroadcastTextID");

            for (int i = 0; i < questsCount; ++i)
                ReadGossipQuestTextData(packet, i, "GossipQuests");

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

        [Parser(Opcode.SMSG_VENDOR_INVENTORY, ClientVersionBuild.V3_4_1_47720)]
        public static void HandleVendorInventory(Packet packet)
        {
            uint entry = packet.ReadPackedGuid128("VendorGUID").GetEntry();
            packet.ReadByte("Reason");
            int count = packet.ReadInt32("VendorItems");

            for (int i = 0; i < count; ++i)
            {
                packet.ReadInt64("Price", i);

                NpcVendor vendor = new NpcVendor
                {
                    Entry = entry,
                    Slot = packet.ReadInt32("Muid", i),
                    Type = (uint)packet.ReadInt32("Type", i)
                };

                packet.ReadInt32("Durability", i);
                int buyCount = packet.ReadInt32("StackCount", i);
                int maxCount = packet.ReadInt32("Quantity", i);
                vendor.ExtendedCost = packet.ReadUInt32("ExtendedCostID", i);
                if (ClientVersion.AddedInVersion(ClientVersionBuild.V3_4_2_49979))
                    vendor.PlayerConditionID = packet.ReadUInt32("PlayerConditionFailed", i);
                
                packet.ReadBit("Locked", i);
                vendor.IgnoreFiltering = packet.ReadBit("DoNotFilterOnVendor", i);
                packet.ReadBit("Refundable", i);

                vendor.Item = Substructures.ItemHandler.ReadItemInstance(packet, i).ItemID;

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
