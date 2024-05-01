using System;
using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class ReputationHandler
    {
        public const int FactionCount = 443;

        [Parser(Opcode.SMSG_INITIALIZE_FACTIONS, ClientVersionBuild.V3_4_1_47720)]
        public static void HandleInitializeFactions(Packet packet)
        {
            for (var i = 0; i < FactionCount; i++)
            {
                packet.ReadUInt16E<FactionFlag>("FactionFlags", i);
                packet.ReadUInt32E<ReputationRank>("FactionStandings", i);
            }

            for (var i = 0; i < FactionCount; i++)
                packet.ReadBit("FactionHasBonus", i);
        }

        [Parser(Opcode.SMSG_SET_FACTION_STANDING)]
        public static void HandleSetFactionStanding(Packet packet)
        {
            float rafBonus = 0;
            if (ClientVersion.RemovedInVersion(ClientVersionBuild.V3_4_1_47720))
                rafBonus =packet.ReadSingle("ReferAFriendBonus");

            float achievementBonus = packet.ReadSingle("BonusFromAchievementSystem");

            var count = packet.ReadInt32();
            List<Tuple<int, int>> reputations = new List<Tuple<int, int>>();
            for (int i = 0; i < count; i++)
            {
                int reputationListId = packet.ReadInt32("Index");
                int standing = packet.ReadInt32("Standing");
                reputations.Add(new Tuple<int, int>(reputationListId, standing));
            }

            packet.ResetBitReader();
            bool showVisual = packet.ReadBit("ShowVisual");

            foreach (var faction in reputations)
            {
                FactionStandingUpdate update = new FactionStandingUpdate();
                update.ShowVisual = showVisual;
                update.RAFBonus = rafBonus;
                update.AchievementBonus = achievementBonus;
                update.ReputationListId = faction.Item1;
                update.Standing = faction.Item2;
                Storage.StoreFactionStandingUpdate(update, packet);
            }
        }
    }
}
