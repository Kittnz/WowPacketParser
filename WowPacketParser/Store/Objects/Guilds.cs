using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("guild")]
    public sealed class GuildTemplate : IDataModel
    {
        [DBFieldName("guild_id", true, true)]
        public string GuildGUID;

        [DBFieldName("name")]
        public string GuildName;

        [DBFieldName("leader_guid")]
        public uint LeaderGUID = 0;

        [DBFieldName("emblem_style")]
        public int EmblemStyle;

        [DBFieldName("emblem_color")]
        public int EmblemColor;

        [DBFieldName("border_style")]
        public int BorderStyle = 0;

        [DBFieldName("border_color")]
        public int BorderColor = 0;

        [DBFieldName("background_color")]
        public int BackgroundColor;

        [DBFieldName("info")]
        public string info = "";

        [DBFieldName("motd")]
        public string motd = "No message set";

        [DBFieldName("create_date")]
        public long CreateDate;
    }

    [DBTableName("guild_rank")]
    public sealed class GuildRankTemplate : IDataModel
    {
        [DBFieldName("guild_id", true, true)]
        public string GuildGUID;

        [DBFieldName("id", true)]
        public int RankID;

        [DBFieldName("name")]
        public string RankName;

        [DBFieldName("rights")]
        public int rights = 67;
    }
}
