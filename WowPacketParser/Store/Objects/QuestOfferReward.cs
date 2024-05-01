using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("quest_offer_reward")]
    public sealed class QuestOfferReward : IDataModel
    {
        [DBFieldName("entry", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("ID", true, DbType = (TargetedDbType.TRINITY))]
        public uint? ID;

        [DBFieldName("sniff_build", true, DbType = (TargetedDbType.WPP))]
        [DBFieldName("VerifiedBuild", DbType = (TargetedDbType.TRINITY))]
        public int? VerifiedBuild = ClientVersion.BuildInt;

        [DBFieldName("emote_id", 4, DbType = (TargetedDbType.WPP))]
        [DBFieldName("Emote", 4, DbType = (TargetedDbType.TRINITY))]
        public int?[] Emote;

        [DBFieldName("emote_delay", 4, DbType = (TargetedDbType.WPP))]
        [DBFieldName("EmoteDelay", 4, DbType = (TargetedDbType.TRINITY))]
        public uint?[] EmoteDelay;

        [DBFieldName("reward_text", DbType = (TargetedDbType.WPP))]
        [DBFieldName("RewardText", DbType = (TargetedDbType.TRINITY))]
        public string RewardText;

        // just because we need it returned from ReadQuestGiverOfferRewardData in 10.x/3.4.x
        public WowGuid QuestGiverGuid;
    }
}
