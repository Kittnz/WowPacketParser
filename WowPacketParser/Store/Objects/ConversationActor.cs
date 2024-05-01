using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("conversation_actors")]
    public sealed class ConversationActor : IDataModel
    {
        [DBFieldName("ConversationId", true)]
        public uint? ConversationId;

        [DBFieldName("ConversationActorId")]
        public int? ConversationActorId;

        [DBFieldName("Idx", true)]
        public uint? Idx;

        [DBFieldName("CreatureId", TargetedDbExpansion.Shadowlands)]
        public uint? CreatureId;

        [DBFieldName("CreatureDisplayInfoId", TargetedDbExpansion.Shadowlands)]
        public uint? CreatureDisplayInfoId;

        [DBFieldName("NoActorObject", TargetedDbExpansion.Shadowlands)]
        public bool? NoActorObject;

        [DBFieldName("ActivePlayerObject", TargetedDbExpansion.Shadowlands)]
        public bool? ActivePlayerObject;

        public WowGuid Guid;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
