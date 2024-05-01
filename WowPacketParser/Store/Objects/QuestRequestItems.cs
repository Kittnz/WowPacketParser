using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("quest_request_items")]
    public sealed class QuestRequestItems : IDataModel
    {
        [DBFieldName("entry", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("ID", true, DbType = (TargetedDbType.TRINITY))]
        public uint? ID;

        [DBFieldName("sniff_build", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("VerifiedBuild", DbType = (TargetedDbType.TRINITY))]
        public int? VerifiedBuild = ClientVersion.BuildInt;

        [DBFieldName("emote_id", false, false, true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("Emote", false, false, true, DbType = (TargetedDbType.TRINITY))]
        public uint? EmoteOnComplete;

        [DBFieldName("emote_delay", TargetedDbExpansion.WarlordsOfDraenor, DbType = (TargetedDbType.WPP))]
        [DBFieldName("EmoteDelay", TargetedDbExpansion.WarlordsOfDraenor, DbType = (TargetedDbType.TRINITY))]
        public uint? EmoteOnCompleteDelay;

        [DBFieldName("completion_text", DbType = (TargetedDbType.WPP))]
        [DBFieldName("CompletionText", DbType = (TargetedDbType.TRINITY))]
        public string CompletionText;
    }
}
