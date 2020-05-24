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

        [DBFieldName("map")]
        public uint? Map;

        [DBFieldName("zone_id")]
        public uint? ZoneID;

        [DBFieldName("area_id")]
        public uint? AreaID;

        [DBFieldName("spawn_mask", TargetedDatabase.Zero, TargetedDatabase.Legion)]
        public uint? SpawnMask;

        [DBFieldName("spawn_difficulties", TargetedDatabase.Legion)]
        public string spawnDifficulties;

        [DBFieldName("phase_mask", TargetedDatabase.Zero, TargetedDatabase.Cataclysm)]
        public uint? PhaseMask;

        [DBFieldName("phase_id", TargetedDatabase.Cataclysm)]
        public string PhaseID;

        [DBFieldName("phase_group")]
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

        [DBFieldName("creator")]
        public uint? CreatedBy;

        [DBFieldName("animprogress")]
        public uint? AnimProgress;

        [DBFieldName("state")]
        public uint? State;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
