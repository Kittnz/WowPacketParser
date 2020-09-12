﻿using System;
using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("creature")]
    public sealed class Creature : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("id")]
        public uint? ID;

        [DBFieldName("map", false, false, true)]
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
        public int? PhaseGroup;

        [DBFieldName("position_x")]
        public float? PositionX;

        [DBFieldName("position_y")]
        public float? PositionY;

        [DBFieldName("position_z")]
        public float? PositionZ;

        [DBFieldName("orientation")]
        public float? Orientation;

        [DBFieldName("wander_distance")]
        public float? WanderDistance;

        [DBFieldName("movement_type")]
        public uint? MovementType;

        [DBFieldName("temp")]
        public byte? TemporarySpawn;

        [DBFieldName("creator")]
        public uint? CreatedBy;

        [DBFieldName("summoner")]
        public uint? SummonedBy;

        [DBFieldName("summon_spell")]
        public uint? SummonSpell;

        [DBFieldName("display_id")]
        public uint? DisplayID;

        [DBFieldName("faction")]
        public uint? FactionTemplate;

        [DBFieldName("level")]
        public uint? Level;

        [DBFieldName("current_health")]
        public uint? CurHealth;

        [DBFieldName("max_health")]
        public uint? MaxHealth;

        [DBFieldName("current_mana")]
        public uint? CurMana;

        [DBFieldName("max_mana")]
        public uint? MaxMana;

        [DBFieldName("speed_walk")]
        public float? SpeedWalk;

        [DBFieldName("speed_run")]
        public float? SpeedRun;

        [DBFieldName("scale")]
        public float? Scale;

        [DBFieldName("base_attack_time")]
        public uint? BaseAttackTime;

        [DBFieldName("ranged_attack_time")]
        public uint? RangedAttackTime;

        [DBFieldName("npc_flags")]
        public uint? NpcFlag;

        [DBFieldName("unit_flags")]
        public uint? UnitFlag;

        [DBFieldName("SniffId", false, false, false, true)]
        public int? SniffId;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("creature_movement_spline")]
    public sealed class CreatureMovementSpline : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("parent_point", true)]
        public uint ParentPoint;

        [DBFieldName("spline_point", true)]
        public uint SplinePoint;

        [DBFieldName("position_x")]
        public float PositionX;

        [DBFieldName("position_y")]
        public float PositionY;

        [DBFieldName("position_z")]
        public float PositionZ;
    }

    [DBTableName("creature_movement")]
    public sealed class CreatureMovement : IDataModel
    {
        [DBFieldName("id", true, true)]
        public string GUID;

        [DBFieldName("point", true)]
        public uint Point;

        [DBFieldName("move_time")]
        public uint MoveTime;

        [DBFieldName("spline_flags")]
        public uint SplineFlags;

        [DBFieldName("spline_count")]
        public uint SplineCount;

        [DBFieldName("start_position_x")]
        public float StartPositionX;

        [DBFieldName("start_position_y")]
        public float StartPositionY;

        [DBFieldName("start_position_z")]
        public float StartPositionZ;  

        [DBFieldName("end_position_x")]
        public float EndPositionX;

        [DBFieldName("end_position_y")]
        public float EndPositionY;

        [DBFieldName("end_position_z")]
        public float EndPositionZ;

        [DBFieldName("orientation")]
        public float? Orientation;

        [DBFieldName("unixtime")]
        public uint? UnixTime;

        public List<Vector3> SplinePoints = null;
    }

    [DBTableName("creature_client_interact")]
    public sealed class CreatureClientInteract : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("unixtime", true)]
        public uint UnixTime;
    }

    [DBTableName("creature_create1_time")]
    public sealed class CreatureCreate1 : IDataModel
    {
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

        [DBFieldName("unixtime", true)]
        public uint UnixTime;
    }

    [DBTableName("creature_create2_time")]
    public sealed class CreatureCreate2 : IDataModel
    {
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

        [DBFieldName("unixtime", true)]
        public uint UnixTime;
    }

    [DBTableName("creature_destroy_time")]
    public sealed class CreatureDestroy : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("unixtime", true)]
        public uint UnixTime;
    }

    [DBTableName("creature_update")]
    public sealed class CreatureUpdate : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("unixtime", true)]
        public uint UnixTime;

        [DBFieldName("entry", true, false, true)]
        public uint? Entry;

        [DBFieldName("display_id", true, false, true)]
        public uint? DisplayID;

        [DBFieldName("mount", true, false, true)]
        public uint? MountDisplayID;

        [DBFieldName("faction", true, false, true)]
        public uint? FactionTemplate;

        [DBFieldName("emote_state", true, false, true)]
        public uint? EmoteState;

        [DBFieldName("stand_state", true, false, true)]
        public uint? StandState;

        [DBFieldName("npc_flags", true, false, true)]
        public uint? NpcFlag;

        [DBFieldName("unit_flags", true, false, true)]
        public uint? UnitFlag;

        [DBFieldName("current_health", true, false, true)]
        public uint? CurrentHealth;

        [DBFieldName("max_health", true, false, true)]
        public uint? MaxHealth;
    }

    [DBTableName("creature_stats")]
    public sealed class CreatureStats : IDataModel
    {
        [DBFieldName("entry", true)]
        public uint Entry;

        [DBFieldName("dmg_min", false, false, true)]
        public float? DmgMin;

        [DBFieldName("dmg_max", false, false, true)]
        public float? DmgMax;

        [DBFieldName("offhand_dmg_min", false, false, true)]
        public float? OffhandDmgMin;

        [DBFieldName("offhand_dmg_max", false, false, true)]
        public float? OffhandDmgMax;

        [DBFieldName("ranged_dmg_min", false, false, true)]
        public float? RangedDmgMin;

        [DBFieldName("ranged_dmg_max", false, false, true)]
        public float? RangedDmgMax;

        [DBFieldName("attack_power", false, false, true)]
        public uint? AttackPower;

        [DBFieldName("ranged_attack_power", false, false, true)]
        public uint? RangedAttackPower;

        [DBFieldName("strength", false, false, true)]
        public uint? Strength;

        [DBFieldName("agility", false, false, true)]
        public uint? Agility;

        [DBFieldName("stamina", false, false, true)]
        public uint? Stamina;

        [DBFieldName("intellect", false, false, true)]
        public uint? Intellect;

        [DBFieldName("spirit", false, false, true)]
        public uint? Spirit;

        [DBFieldName("armor", false, false, true)]
        public int? Armor;

        [DBFieldName("holy_res", false, false, true)]
        public int? HolyResistance;

        [DBFieldName("fire_res", false, false, true)]
        public int? FireResistance;

        [DBFieldName("nature_res", false, false, true)]
        public int? NatureResistance;

        [DBFieldName("frost_res", false, false, true)]
        public int? FrostResistance;

        [DBFieldName("shadow_res", false, false, true)]
        public int? ShadowResistance;

        [DBFieldName("arcane_res", false, false, true)]
        public int? ArcaneResistance;
    }

    public sealed class CreatureEmote
    {
        public CreatureEmote(EmoteType emote_, DateTime time_)
        {
            emote = emote_;
            time = time_;
        }
        public EmoteType emote;
        public DateTime time;
    }

    [DBTableName("creature_target_change")]
    public sealed class CreatureTargetChange : IDataModel
    {
        [DBFieldName("guid", true, true)]
        public string GUID;

        [DBFieldName("victim_guid", false, true)]
        public string VictimGuid;

        [DBFieldName("victim_id")]
        public uint VictimId;

        [DBFieldName("victim_type")]
        public string VictimType;

        [DBFieldName("unixtime", true)]
        public uint UnixTime;
    }

    public sealed class CreatureTargetData
    {
        public CreatureTargetData(WowGuid victim_, DateTime time_)
        {
            victim = victim_;
            time = time_;
        }
        public WowGuid victim;
        public DateTime time;
    }
}
