﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V7_0_3_22248.Parsers
{
    public static class TaxiHandler
    {
        [Parser(Opcode.SMSG_SHOW_TAXI_NODES, ClientVersionBuild.V7_3_0_24920)]
        public static void HandleShowTaxiNodes(Packet packet)
        {
            var hasWindowInfo = packet.ReadBit("HasWindowInfo");
            var canLandNodesCount = packet.ReadUInt32();
            var canUseNodesCount = packet.ReadUInt32();

            if (hasWindowInfo)
            {
                packet.ReadPackedGuid128("UnitGUID");
                packet.ReadUInt32("CurrentNode");
            }

            for (var i = 0u; i < canLandNodesCount; ++i)
                packet.ReadByte("CanLandNodes", i);

            for (var i = 0u; i < canUseNodesCount; ++i)
                packet.ReadByte("CanUseNodes", i);

            CoreParsers.NpcHandler.LastGossipOption.Guid = null;
            CoreParsers.NpcHandler.LastGossipOption.MenuId = null;
            CoreParsers.NpcHandler.LastGossipOption.OptionIndex = null;
            CoreParsers.NpcHandler.LastGossipOption.ActionMenuId = null;
            CoreParsers.NpcHandler.LastGossipOption.ActionMenuId = null;

            CoreParsers.NpcHandler.TempGossipOptionPOI.Guid = null;
            CoreParsers.NpcHandler.TempGossipOptionPOI.MenuId = null;
            CoreParsers.NpcHandler.TempGossipOptionPOI.OptionIndex = null;
            CoreParsers.NpcHandler.TempGossipOptionPOI.ActionMenuId = null;
            CoreParsers.NpcHandler.TempGossipOptionPOI.ActionMenuId = null;
        }

        [Parser(Opcode.CMSG_ACTIVATE_TAXI)]
        public static void HandleActivateTaxi(Packet packet)
        {
            packet.ReadPackedGuid128("Vendor");
            packet.ReadUInt32("Node");
            packet.ReadUInt32("GroundMountID");
            packet.ReadUInt32("FlyingMountID");
        }
    }
}
