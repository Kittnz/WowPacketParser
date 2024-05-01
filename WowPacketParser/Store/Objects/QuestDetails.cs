using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("quest_details")]
    public sealed class QuestDetails : IDataModel
    {
        [DBFieldName("entry", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("ID", true, DbType = (TargetedDbType.TRINITY))]
        public uint? ID;

        [DBFieldName("sniff_build", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("VerifiedBuild", DbType = (TargetedDbType.TRINITY))]
        public int? VerifiedBuild = ClientVersion.BuildInt;

        [DBFieldName("emote_id", 4, DbType = (TargetedDbType.WPP))]
        [DBFieldName("Emote", 4, DbType = (TargetedDbType.TRINITY))]
        public uint?[] Emote;

        [DBFieldName("emote_delay", 4, DbType = (TargetedDbType.WPP))]
        [DBFieldName("EmoteDelay", 4, DbType = (TargetedDbType.TRINITY))]
        public uint?[] EmoteDelay;
    }
}