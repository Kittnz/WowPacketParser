﻿using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("gameobject")]
    public sealed class GameObjectModel : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("id")]
        public uint? ID;

        [DBFieldName("map", false, false, true)]
        public uint? Map;

        [DBFieldName("zone_id", DbType = (TargetedDbType.WPP))]
        [DBFieldName("zoneId", DbType = (TargetedDbType.TRINITY))]
        public uint? ZoneID;

        [DBFieldName("area_id", DbType = (TargetedDbType.WPP))]
        [DBFieldName("areaId", DbType = (TargetedDbType.TRINITY))]
        public uint? AreaID;

        [DBFieldName("spawn_mask", TargetedDbExpansion.WrathOfTheLichKing, TargetedDbExpansion.Legion, DbType = (TargetedDbType.WPP))]
        [DBFieldName("spawnMask", TargetedDbExpansion.WrathOfTheLichKing, TargetedDbExpansion.Legion, DbType = (TargetedDbType.TRINITY | TargetedDbType.CMANGOS))]
        public uint? SpawnMask;

        [DBFieldName("spawn_difficulties", TargetedDbExpansion.Legion, DbType = (TargetedDbType.WPP))]
        [DBFieldName("spawnDifficulties", TargetedDbExpansion.Legion, DbType = (TargetedDbType.TRINITY))]
        public string SpawnDifficulties;

        [DBFieldName("phase_mask", TargetedDbExpansion.WrathOfTheLichKing, TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.WPP))]
        [DBFieldName("phaseMask", TargetedDbExpansion.WrathOfTheLichKing, TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.TRINITY | TargetedDbType.CMANGOS))]
        public uint? PhaseMask;

        [DBFieldName("phase_id", TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.WPP))]
        [DBFieldName("PhaseId", TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.TRINITY))]
        public string PhaseID;

        [DBFieldName("phase_group", TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.WPP))]
        [DBFieldName("PhaseGroup", TargetedDbExpansion.Cataclysm, DbType = (TargetedDbType.TRINITY))]
        public uint? PhaseGroup;

        [DBFieldName("position_x")]
        public float? PositionX;

        [DBFieldName("position_y")]
        public float? PositionY;

        [DBFieldName("position_z")]
        public float? PositionZ;

        [DBFieldName("orientation")]
        public float? Orientation;

        [DBFieldName("rotation", 4, true)]
        public float?[] Rotation;

        [DBFieldName("temp", DbType = (TargetedDbType.WPP))]
        public byte? TemporarySpawn;

        [DBFieldName("creator_guid", false, true, DbType = (TargetedDbType.WPP))]
        public string CreatedByGuid;

        [DBFieldName("creator_id", DbType = (TargetedDbType.WPP))]
        public uint CreatedById;

        [DBFieldName("creator_type", DbType = (TargetedDbType.WPP))]
        public string CreatedByType;

        [DBFieldName("display_id", DbType = (TargetedDbType.WPP))]
        public uint? DisplayID;

        [DBFieldName("level", DbType = (TargetedDbType.WPP))]
        public uint? Level;

        [DBFieldName("faction", DbType = (TargetedDbType.WPP))]
        public uint? Faction;

        [DBFieldName("flags", DbType = (TargetedDbType.WPP))]
        public uint? Flags;

        [DBFieldName("state")]
        public uint? State;

        [DBFieldName("animprogress")]
        public uint? AnimProgress;

        [DBFieldName("sniff_id", false, false, false, true, DbType = (TargetedDbType.WPP))]
        public int? SniffId;

        [DBFieldName("sniff_build", DbType = (TargetedDbType.WPP))]
        [DBFieldName("VerifiedBuild", DbType = (TargetedDbType.TRINITY))]
        public int? SniffBuild = ClientVersion.BuildInt;
    }

    [DBTableName("gameobject_create1_time")]
    public sealed class GameObjectCreate1 : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("position_x")]
        public float? PositionX;

        [DBFieldName("position_y")]
        public float? PositionY;

        [DBFieldName("position_z")]
        public float? PositionZ;

        [DBFieldName("orientation")]
        public float? Orientation;
    }

    [DBTableName("gameobject_create2_time")]
    public sealed class GameObjectCreate2 : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("position_x")]
        public float? PositionX;

        [DBFieldName("position_y")]
        public float? PositionY;

        [DBFieldName("position_z")]
        public float? PositionZ;

        [DBFieldName("orientation")]
        public float? Orientation;
    }

    [DBTableName("gameobject_destroy_time")]
    public sealed class GameObjectDestroy : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;
    }

    [DBTableName("gameobject_values_update")]
    public sealed class GameObjectUpdate : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("display_id", false, false, true)]
        public uint? DisplayID;

        [DBFieldName("level", false, false, true)]
        public uint? Level;

        [DBFieldName("faction", false, false, true)]
        public uint? Faction;

        [DBFieldName("flags", false, false, true)]
        public uint? Flags;

        [DBFieldName("state", false, false, true)]
        public uint? State;

        [DBFieldName("animprogress", false, false, true)]
        public uint? AnimProgress;
    }

    [DBTableName("gameobject_custom_anim")]
    public sealed class GameObjectCustomAnim : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("anim_id")]
        public int AnimId;

        [DBFieldName("as_despawn", false, false, true)]
        public bool? AsDespawn;
    }

    [DBTableName("gameobject_despawn_anim")]
    public sealed class GameObjectDespawnAnim : IDataModel
    {
        [DBFieldName("unixtimems", true)]
        public ulong UnixTimeMs;

        [DBFieldName("guid", true, true)]
        public string GUID;
    }
}
