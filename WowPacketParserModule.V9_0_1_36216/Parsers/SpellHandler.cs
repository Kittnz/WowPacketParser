﻿using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParserModule.V9_0_1_36216.Parsers
{
    public static class SpellHandler
    {
        public static void ReadSpellCastData(Packet packet, params object[] idx)
        {
            packet.ReadPackedGuid128("CasterGUID", idx);
            packet.ReadPackedGuid128("CasterUnit", idx);

            packet.ReadPackedGuid128("CastID", idx);
            packet.ReadPackedGuid128("OriginalCastID", idx);

            var spellID = packet.ReadUInt32<SpellId>("SpellID", idx);
            ReadSpellCastVisual(packet, idx, "Visual");

            packet.ReadUInt32("CastFlags", idx);
            packet.ReadUInt32("CastFlagsEx", idx);
            packet.ReadUInt32("CastTime", idx);

            V6_0_2_19033.Parsers.SpellHandler.ReadMissileTrajectoryResult(packet, idx, "MissileTrajectory");

            packet.ReadInt32("Ammo.DisplayID", idx);

            packet.ReadByte("DestLocSpellCastIndex", idx);

            V6_0_2_19033.Parsers.SpellHandler.ReadCreatureImmunities(packet, idx, "Immunities");

            V6_0_2_19033.Parsers.SpellHandler.ReadSpellHealPrediction(packet, idx, "Predict");

            packet.ResetBitReader();

            var hitTargetsCount = packet.ReadBits("HitTargetsCount", 16, idx);
            var missTargetsCount = packet.ReadBits("MissTargetsCount", 16, idx);
            var hitStatusCount = packet.ReadBits("HitStatusCount", 16, idx);
            var missStatusCount = packet.ReadBits("MissStatusCount", 16, idx);
            var remainingPowerCount = packet.ReadBits("RemainingPowerCount", 9, idx);

            var hasRuneData = packet.ReadBit("HasRuneData", idx);
            var targetPointsCount = packet.ReadBits("TargetPointsCount", 16, idx);

            for (var i = 0; i < missStatusCount; ++i)
                V6_0_2_19033.Parsers.SpellHandler.ReadSpellMissStatus(packet, idx, "MissStatus", i);

            V8_0_1_27101.Parsers.SpellHandler.ReadSpellTargetData(packet, spellID, idx, "Target");

            for (var i = 0; i < hitTargetsCount; ++i)
                packet.ReadPackedGuid128("HitTarget", idx, i);

            for (var i = 0; i < missTargetsCount; ++i)
                packet.ReadPackedGuid128("MissTarget", idx, i);

            for (var i = 0; i < hitStatusCount; ++i)
                packet.ReadByte("HitStatus", idx, i);

            for (var i = 0; i < remainingPowerCount; ++i)
                V6_0_2_19033.Parsers.SpellHandler.ReadSpellPowerData(packet, idx, "RemainingPower", i);

            if (hasRuneData)
                V7_0_3_22248.Parsers.SpellHandler.ReadRuneData(packet, idx, "RemainingRunes");

            for (var i = 0; i < targetPointsCount; ++i)
                V6_0_2_19033.Parsers.SpellHandler.ReadLocation(packet, idx, "TargetPoints", i);
        }

        [Parser(Opcode.SMSG_SPELL_START)]
        public static void HandleSpellStart(Packet packet)
        {
            ReadSpellCastData(packet, "Cast");
        }

        [Parser(Opcode.SMSG_SPELL_GO)]
        public static void HandleSpellGo(Packet packet)
        {
            ReadSpellCastData(packet, "Cast");

            packet.ResetBitReader();

            var hasLogData = packet.ReadBit();
            if (hasLogData)
                V8_0_1_27101.Parsers.SpellHandler.ReadSpellCastLogData(packet, "LogData");
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_AURA_UPDATE)]
        public static void HandleAuraUpdate(Packet packet)
        {
            packet.ReadBit("UpdateAll");
            var count = packet.ReadBits("AurasCount", 9);

            var auras = new List<Aura>();
            for (var i = 0; i < count; ++i)
            {
                var aura = new Aura();

                packet.ReadByte("Slot", i);

                packet.ResetBitReader();
                var hasAura = packet.ReadBit("HasAura", i);
                if (hasAura)
                {
                    packet.ReadPackedGuid128("CastID", i);
                    aura.SpellId = (uint)packet.ReadInt32<SpellId>("SpellID", i);
                    ReadSpellCastVisual(packet, i, "Visual");
                    aura.AuraFlags = packet.ReadUInt16E<AuraFlagMoP>("Flags", i);
                    packet.ReadUInt32("ActiveFlags", i);
                    aura.Level = packet.ReadUInt16("CastLevel", i);
                    aura.Charges = packet.ReadByte("Applications", i);
                    packet.ReadInt32("ContentTuningID", i);

                    packet.ResetBitReader();

                    var hasCastUnit = packet.ReadBit("HasCastUnit", i);
                    var hasDuration = packet.ReadBit("HasDuration", i);
                    var hasRemaining = packet.ReadBit("HasRemaining", i);

                    var hasTimeMod = packet.ReadBit("HasTimeMod", i);

                    var pointsCount = packet.ReadBits("PointsCount", 6, i);
                    var effectCount = packet.ReadBits("EstimatedPoints", 6, i);

                    var hasContentTuning = packet.ReadBit("HasContentTuning", i);

                    if (hasContentTuning)
                        CombatLogHandler.ReadContentTuningParams(packet, i, "ContentTuning");

                    if (hasCastUnit)
                        packet.ReadPackedGuid128("CastUnit", i);

                    aura.Duration = hasDuration ? packet.ReadInt32("Duration", i) : 0;
                    aura.MaxDuration = hasRemaining ? packet.ReadInt32("Remaining", i) : 0;

                    if (hasTimeMod)
                        packet.ReadSingle("TimeMod");

                    for (var j = 0; j < pointsCount; ++j)
                        packet.ReadSingle("Points", i, j);

                    for (var j = 0; j < effectCount; ++j)
                        packet.ReadSingle("EstimatedPoints", i, j);

                    auras.Add(aura);
                    packet.AddSniffData(StoreNameType.Spell, (int)aura.SpellId, "AURA_UPDATE");
                }
            }

            var guid = packet.ReadPackedGuid128("UnitGUID");

            if (Storage.Objects.ContainsKey(guid))
            {
                var unit = Storage.Objects[guid].Item1 as Unit;
                if (unit != null)
                {
                    // If this is the first packet that sends auras
                    // (hopefully at spawn time) add it to the "Auras" field,
                    // if not create another row of auras in AddedAuras
                    // (similar to ChangedUpdateFields)

                    if (unit.Auras == null)
                        unit.Auras = auras;
                    else
                        unit.AddedAuras.Add(auras);
                }
            }
        }

        [Parser(Opcode.SMSG_CAST_FAILED)]
        public static void HandleCastFailed(Packet packet)
        {
            packet.ReadPackedGuid128("CastID");
            packet.ReadInt32<SpellId>("SpellID");
            ReadSpellCastVisual(packet, "Visual");
            packet.ReadInt32("Reason");
            packet.ReadInt32("FailedArg1");
            packet.ReadInt32("FailedArg2");
        }

        [Parser(Opcode.SMSG_SPELL_FAILURE)]
        public static void HandleSpellFailure(Packet packet)
        {
            packet.ReadPackedGuid128("CasterUnit");
            packet.ReadPackedGuid128("CastID");
            packet.ReadInt32<SpellId>("SpellID");
            ReadSpellCastVisual(packet, "Visual");
            packet.ReadInt16E<SpellCastFailureReason>("Reason");
        }

        [Parser(Opcode.SMSG_SPELL_FAILED_OTHER)]
        public static void HandleSpellFailedOther(Packet packet)
        {
            packet.ReadPackedGuid128("CasterUnit");
            packet.ReadPackedGuid128("CastID");
            packet.ReadUInt32<SpellId>("SpellID");
            ReadSpellCastVisual(packet, "Visual");
            packet.ReadByteE<SpellCastFailureReason>("Reason");
        }

        [Parser(Opcode.SMSG_LEARNED_SPELLS)]
        public static void HandleLearnedSpells(Packet packet)
        {
            var spellCount = packet.ReadUInt32("SpellCount");
            var favoriteSpellCount = packet.ReadUInt32("FavoriteSpellCount");
            packet.ReadUInt32("SpecializationID");

            for (var i = 0; i < spellCount; ++i)
                packet.ReadInt32<SpellId>("SpellID", i);

            for (var i = 0; i < favoriteSpellCount; ++i)
                packet.ReadInt32<SpellId>("FavoriteSpellID", i);

            packet.ReadBit("SuppressMessaging");
        }

        public static void ReadSpellCastVisual(Packet packet, params object[] indexes)
        {
            packet.ReadInt32("SpellXSpellVisualID", indexes);
            packet.ReadInt32("ScriptVisualID", indexes);
        }
    }
}
