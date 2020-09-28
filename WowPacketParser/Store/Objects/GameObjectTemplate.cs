﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gameobject_template")]
    public sealed class GameObjectTemplate : IDataModel
    {
        [DBFieldName("entry", true)]
        public uint? Entry;

        [DBFieldName("type")]
        public GameObjectType? Type;

        [DBFieldName("displayId")]
        public uint? DisplayID;

        [DBFieldName("name", LocaleConstant.enUS)] // ToDo: Add locale support
        public string Name;

        [DBFieldName("icon_name")]
        public string IconName;

        [DBFieldName("cast_bar_caption", LocaleConstant.enUS)] // ToDo: Add locale support
        public string CastCaption;

        [DBFieldName("unk1")]
        public string UnkString;

        [DBFieldName("size")]
        public float? Size;

        //TODO: move to gameobject_questitem
        public uint?[] QuestItems;

        [DBFieldName("data", TargetedDatabase.Zero, TargetedDatabase.Cataclysm, 24, true)]
        [DBFieldName("data", TargetedDatabase.Cataclysm, TargetedDatabase.WarlordsOfDraenor, 32, true)]
        [DBFieldName("data", TargetedDatabase.WarlordsOfDraenor, TargetedDatabase.BattleForAzeroth, 33, true)]
        [DBFieldName("data", TargetedDatabase.BattleForAzeroth, 34, true)]
        public int?[] Data;

        [DBFieldName("required_level", TargetedDatabase.Cataclysm)]
        public int? RequiredLevel;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("gameobject_questitem")]
    public sealed class GameObjectTemplateQuestItem : IDataModel
    {
        [DBFieldName("GameObjectEntry", true)]
        public uint? GameObjectEntry;

        [DBFieldName("Idx", true)]
        public uint? Idx;

        [DBFieldName("ItemId")]
        public uint? ItemId;

        [DBFieldName("VerifiedBuild", TargetedDatabase.WarlordsOfDraenor)]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
