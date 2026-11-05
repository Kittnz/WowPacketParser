using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using LfgHandler602 = WowPacketParserModule.V6_0_2_19033.Parsers.LfgHandler;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class LfgHandler
    {
        // 3.4.x join request: activity id list first, then a 40 bit block (10 bit name length, 11 bit comment length,
        // 8 bit voice chat length, 11 flag bits), then the strings (sniff-verified on 3.4.0.45327-46158)
        public static void ReadLfgListJoinRequest(Packet packet, params object[] idx)
        {
            var activityCount = packet.ReadUInt32("ActivityIDCount", idx);
            packet.ReadSingle("RequiredItemLevel", idx);
            packet.ReadUInt32("RequiredHonorLevel", idx);

            for (var i = 0; i < activityCount; i++)
                packet.ReadInt32("GroupFinderActivityId", idx, i);

            packet.ResetBitReader();
            var lenName = packet.ReadBits("NameLength", 10);
            var lenComment = packet.ReadBits("CommentLength", 11);
            var lenVoiceChat = packet.ReadBits("VoiceChatLength", 8);
            packet.ReadBits("Flags", 11, idx);

            packet.ReadWoWString("Name", lenName, idx);
            packet.ReadWoWString("Comment", lenComment, idx);
            packet.ReadWoWString("VoiceChat", lenVoiceChat, idx);
        }

        public static void ReadLfgListSearchResultMemberInfo(Packet packet, params object[] idx)
        {
            packet.ReadPackedGuid128("Member", idx);
            packet.ReadByteE<Class>("Class", idx);
            packet.ReadByte("Role", idx);
            packet.ReadInt32("Unk32", idx);
            packet.ReadByte("RolesMask", idx);
            packet.ResetBitReader();
            packet.ReadBit("UnkBit", idx);
        }

        public static void ReadLfgListSearchResult(Packet packet, params object[] idx)
        {
            LfgHandler602.ReadCliRideTicket(packet, idx, "LFGListRideTicket");

            packet.ReadUInt32("SequenceNum", idx);

            packet.ReadPackedGuid128("Leader", idx);
            packet.ReadPackedGuid128("LastTouchedAny", idx);
            packet.ReadPackedGuid128("LastTouchedName", idx);
            packet.ReadPackedGuid128("LastTouchedComment", idx);
            packet.ReadPackedGuid128("LastTouchedVoiceChat", idx);

            packet.ReadUInt32("VirtualRealmAddress", idx);
            packet.ReadUInt32("CompletedEncountersMask", idx);

            var bnetFriendCount = packet.ReadUInt32("BNetFriendCount", idx);
            var characterFriendCount = packet.ReadUInt32("CharacterFriendCount", idx);
            var guildMateCount = packet.ReadUInt32("GuildMateCount", idx);
            var unkGuidCount = packet.ReadUInt32("UnkGuidCount", idx);
            var memberCount = packet.ReadUInt32("MemberCount", idx);
            packet.ReadUInt32("Unk", idx);
            packet.ReadTime64("CreationTime", idx);

            packet.ResetBitReader();
            packet.ReadBit("UnkBit", idx);
            packet.ReadPackedGuid128("PartyGUID", idx);

            for (var i = 0; i < bnetFriendCount; i++)
                packet.ReadPackedGuid128("BNetFriends", idx, i);
            for (var i = 0; i < characterFriendCount; i++)
                packet.ReadPackedGuid128("CharacterFriends", idx, i);
            for (var i = 0; i < guildMateCount; i++)
                packet.ReadPackedGuid128("GuildMates", idx, i);
            for (var i = 0; i < unkGuidCount; i++)
                packet.ReadPackedGuid128("UnkGuids", idx, i);

            ReadLfgListJoinRequest(packet, idx, "LFGListJoinRequest");

            packet.ResetBitReader();
            packet.ReadBit("UnkBit2", idx);

            for (var i = 0; i < memberCount; i++)
                ReadLfgListSearchResultMemberInfo(packet, "Members", idx, i);
        }

        [Parser(Opcode.SMSG_LFG_LIST_SEARCH_RESULTS)]
        public static void HandleLfgListSearchResults(Packet packet)
        {
            packet.ReadUInt16("TotalResults");
            var resultCount = packet.ReadUInt32("ResultCount");

            for (var i = 0; i < resultCount; i++)
                ReadLfgListSearchResult(packet, "Entry", i);
        }

        [Parser(Opcode.SMSG_LFG_LIST_UPDATE_STATUS)]
        public static void HandleLfgListUpdateStatus(Packet packet)
        {
            LfgHandler602.ReadCliRideTicket(packet, "RideTicket");
            packet.ReadTime64("RemainingTime");
            packet.ReadByte("ResultId");
            ReadLfgListJoinRequest(packet, "LFGListJoinRequest");
            packet.ResetBitReader();
            packet.ReadBit("Listed");
        }

        public static void ReadLfgListSearchResultPartialUpdate(Packet packet, params object[] idx)
        {
            LfgHandler602.ReadCliRideTicket(packet, idx, "Ticket");
            packet.ReadUInt32("SequenceNum", idx);
            var memberCount = packet.ReadUInt32("MemberCount", idx);

            packet.ResetBitReader();
            var hasLeader = packet.ReadBit("ChangeLeader", idx);
            var hasVirtualRealmAddress = packet.ReadBit("ChangeVirtualRealmAddress", idx);
            var hasCompletedEncountersMask = packet.ReadBit("ChangeCompletedEncountersMask", idx);
            packet.ReadBit("Unk3", idx);
            packet.ReadBit("Unk4", idx);
            packet.ReadBit("Unk5", idx);
            var hasAny = packet.ReadBit("ChangeLastTouchedAny", idx);
            var hasName = packet.ReadBit("ChangeLastTouchedName", idx);
            var hasComment = packet.ReadBit("ChangeLastTouchedComment", idx);
            var hasVoice = packet.ReadBit("ChangeLastTouchedVoiceChat", idx);
            packet.ReadBits("UnkFlags", 14, idx);

            ReadLfgListJoinRequest(packet, idx, "LFGListJoinRequest");

            if (hasLeader)
                packet.ReadPackedGuid128("Leader", idx);
            if (hasVirtualRealmAddress)
                packet.ReadUInt32("VirtualRealmAddress", idx);
            if (hasCompletedEncountersMask)
                packet.ReadUInt32("CompletedEncountersMask", idx);
            if (hasAny)
                packet.ReadPackedGuid128("LastTouchedAny", idx);
            if (hasName)
                packet.ReadPackedGuid128("LastTouchedName", idx);
            if (hasComment)
                packet.ReadPackedGuid128("LastTouchedComment", idx);
            if (hasVoice)
                packet.ReadPackedGuid128("LastTouchedVoiceChat", idx);

            for (var i = 0; i < memberCount; i++)
                ReadLfgListSearchResultMemberInfo(packet, "Members", idx, i);
        }

        [Parser(Opcode.SMSG_LFG_LIST_SEARCH_RESULTS_UPDATE)]
        public static void HandleLfgListSearchResultsUpdate(Packet packet)
        {
            var count = packet.ReadUInt32("Count");

            for (var i = 0; i < count; i++)
                ReadLfgListSearchResultPartialUpdate(packet, "Update", i);
        }
    }
}
