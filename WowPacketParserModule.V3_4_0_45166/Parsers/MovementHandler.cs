using System;
using System.Collections.Generic;
using System.Linq;
using WowPacketParser.DBC;
using WowPacketParser.Enums;
using WowPacketParser.Enums.Version;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using CoreParsers = WowPacketParser.Parsing.Parsers;
using MovementFlag = WowPacketParser.Enums.v4.MovementFlag;
using MovementFlag2 = WowPacketParser.Enums.v4.MovementFlag2;
using SplineFacingType = WowPacketParserModule.V6_0_2_19033.Enums.SplineFacingType;

namespace WowPacketParserModule.V3_4_0_45166.Parsers
{
    public static class MovementHandler
    {
        public static void ReadMonsterSplineFilter(Packet packet, params object[] indexes)
        {
            var count = packet.ReadUInt32("MonsterSplineFilterKey", indexes);
            packet.ReadSingle("BaseSpeed", indexes);
            packet.ReadInt16("StartOffset", indexes);
            packet.ReadSingle("DistToPrevFilterKey", indexes);
            packet.ReadInt16("AddedToStart", indexes);

            for (int i = 0; i < count; i++)
            {
                packet.ReadInt16("IDx", indexes, i);
                packet.ReadUInt16("Speed", indexes, i);
            }

            packet.ResetBitReader();
            packet.ReadBits("FilterFlags", 2, indexes);
        }

        public static void ReadMonsterSplineSpellEffectExtraData(Packet packet, params object[] indexes)
        {
            packet.ReadPackedGuid128("TargetGUID", indexes);
            packet.ReadUInt32("SpellVisualID", indexes);
            packet.ReadUInt32("ProgressCurveID", indexes);
            packet.ReadUInt32("ParabolicCurveID", indexes);
            packet.ReadSingle("JumpGravity", indexes);
        }

        public static void ReadMonsterSplineJumpExtraData(Packet packet, params object[] indexes)
        {
            packet.ReadSingle("JumpGravity", indexes);
            packet.ReadUInt32("StartTime", indexes);
            packet.ReadUInt32("Duration", indexes);
        }

        public static void ReadMovementSpline(ServerSideMovement monsterMove, Packet packet, Vector3 pos, params object[] indexes)
        {
            uint splineFlags = (uint)packet.ReadUInt32E<SplineFlag>("Flags", indexes);
            if (monsterMove != null)
                monsterMove.SplineFlags = splineFlags;
            if (ClientVersion.RemovedInVersion(ClientType.Shadowlands))
            {
                packet.ReadByte("AnimTier", indexes);
                packet.ReadUInt32("TierTransStartTime", indexes);
            }
            packet.ReadInt32("Elapsed", indexes);
            uint moveTime = packet.ReadUInt32("MoveTime", indexes);
            if (monsterMove != null)
                monsterMove.MoveTime = moveTime;
            packet.ReadUInt32("FadeObjectTime", indexes);

            packet.ReadByte("Mode", indexes);
            if (ClientVersion.RemovedInVersion(ClientType.Shadowlands))
                packet.ReadByte("VehicleExitVoluntary", indexes);

            WowGuid transportGuid = packet.ReadPackedGuid128("TransportGUID", indexes);
            if (monsterMove != null)
                monsterMove.TransportGuid = transportGuid;
            sbyte seat = packet.ReadSByte("VehicleSeat", indexes);
            if (monsterMove != null)
                monsterMove.TransportSeat = seat;

            packet.ResetBitReader();

            var type = packet.ReadBitsE<SplineFacingType>("Face", 2, indexes);
            var pointsCount = packet.ReadBits("PointsCount", 16, indexes);
            if (ClientVersion.AddedInVersion(ClientType.Shadowlands))
            {
                packet.ReadBit("VehicleExitVoluntary", indexes);
                packet.ReadBit("Interpolate", indexes);
            }
            var packedDeltasCount = packet.ReadBits("PackedDeltasCount", 16, indexes);
            var totalPointsCount = pointsCount + packedDeltasCount;
            var hasSplineFilter = packet.ReadBit("HasSplineFilter", indexes);
            var hasSpellEffectExtraData = packet.ReadBit("HasSpellEffectExtraData", indexes);
            var hasJumpExtraData = packet.ReadBit("HasJumpExtraData", indexes);

            var hasAnimTier = false;
            if (ClientVersion.AddedInVersion(ClientType.Shadowlands))
                hasAnimTier = packet.ReadBit("HasAnimTierTransition", indexes);

            var hasUnk901 = false;
            if (ClientVersion.AddedInVersion(ClientType.Shadowlands) && !ClientVersion.IsClassicClientVersionBuild(ClientVersion.Build))
                hasUnk901 = packet.ReadBit("HasUnknown901", indexes);

            if (hasSplineFilter)
                ReadMonsterSplineFilter(packet, indexes, "MonsterSplineFilter");

            float orientation = 100;
            switch (type)
            {
                case SplineFacingType.Spot:
                    var faceSpot = packet.ReadVector3("FaceSpot", indexes);
                    orientation = Utilities.GetAngle(pos.X, pos.Y, faceSpot.X, faceSpot.Y);
                    break;
                case SplineFacingType.Target:
                    orientation = packet.ReadSingle("FaceDirection", indexes);
                    packet.ReadPackedGuid128("FacingGUID", indexes);
                    break;
                case SplineFacingType.Angle:
                    orientation = packet.ReadSingle("FaceDirection", indexes);
                    break;
                default:
                    break;
            }

            if (monsterMove != null)
            {
                monsterMove.Orientation = orientation;
                monsterMove.SplineCount = totalPointsCount;
                if (totalPointsCount > 0)
                    monsterMove.SplinePoints = new List<Vector3>();
            }

            Vector3 endpos = new Vector3();

            double overallDist = 0.0f;
            List<Vector3> pointsList = (monsterMove != null) ? new List<Vector3>() : null;
            for (int i = 0; i < pointsCount; i++)
            {
                var spot = packet.ReadVector3();

                // euclidean distance
                overallDist += Math.Sqrt(Math.Pow(spot.X - pos.X, 2) + Math.Pow(spot.Y - pos.Y, 2) + Math.Pow(spot.Z - pos.Z, 2));

                // client always taking first point
                if (i == 0)
                    endpos = spot;

                if (monsterMove != null)
                    pointsList.Add(spot);
                packet.AddValue("Points", spot, indexes, i);
            }

            var waypoints = new Vector3[packedDeltasCount];
            for (int i = 0; i < packedDeltasCount; i++)
            {
                var packedDeltas = packet.ReadPackedVector3();
                waypoints[i].X = packedDeltas.X;
                waypoints[i].Y = packedDeltas.Y;
                waypoints[i].Z = packedDeltas.Z;
            }

            if (hasSpellEffectExtraData)
                ReadMonsterSplineSpellEffectExtraData(packet, indexes, "MonsterSplineSpellEffectExtra");

            if (hasJumpExtraData)
                ReadMonsterSplineJumpExtraData(packet, indexes, "MonsterSplineJumpExtraData");

            if (hasAnimTier)
            {
                packet.ReadInt32("TierTransitionID", indexes);
                packet.ReadUInt32("StartTime", indexes);
                packet.ReadUInt32("EndTime", indexes);
                packet.ReadByte("AnimTier", indexes);
            }

            if (hasUnk901)
            {
                for (var i = 0; i < 16; ++i)
                {
                    packet.ReadInt32("Unknown1", indexes, "Unknown901", i);
                    packet.ReadInt32("Unknown2", indexes, "Unknown901", i);
                    packet.ReadInt32("Unknown3", indexes, "Unknown901", i);
                    packet.ReadInt32("Unknown4", indexes, "Unknown901", i);
                }
            }

            // Calculate mid pos
            var mid = new Vector3
            {
                X = (pos.X + endpos.X) * 0.5f,
                Y = (pos.Y + endpos.Y) * 0.5f,
                Z = (pos.Z + endpos.Z) * 0.5f
            };

            for (var i = 0; i < packedDeltasCount; ++i)
            {
                var vec = new Vector3
                {
                    X = mid.X - waypoints[i].X,
                    Y = mid.Y - waypoints[i].Y,
                    Z = mid.Z - waypoints[i].Z
                };

                if (monsterMove != null)
                    monsterMove.SplinePoints.Add(vec);

                packet.AddValue("WayPoints", vec, indexes, i);
            }

            if (monsterMove != null)
            {
                foreach (var point in pointsList)
                {
                    monsterMove.SplinePoints.Add(point);
                }
            }

            float moveTimeInSec = (float)monsterMove.MoveTime / 1000;
            float speedXY = (float)overallDist / moveTimeInSec;
            packet.AddValue("CalculatedSpeedXY", speedXY, indexes);
        }

        public static void ReadMovementMonsterSpline(ServerSideMovement monsterMove, Packet packet, Vector3 pos, params object[] indexes)
        {
            packet.ReadUInt32("Id", indexes);
            packet.ReadVector3("Destination", indexes);

            packet.ResetBitReader();

            packet.ReadBit("CrzTeleport", indexes);
            packet.ReadBits("StopDistanceTolerance", 3, indexes);

            ReadMovementSpline(monsterMove, packet, pos, indexes, "MovementSpline");
        }

        [Parser(Opcode.SMSG_LOGIN_SET_TIME_SPEED)]
        public static void HandleLoginSetTimeSpeed(Packet packet)
        {
            packet.ReadPackedTime("ServerTime");
            packet.ReadPackedTime("GameTime");
            packet.ReadSingle("NewSpeed");
            packet.ReadInt32("ServerTimeHolidayOffset");
            packet.ReadInt32("GameTimeHolidayOffset");
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_NEW_WORLD)]
        public static void HandleNewWorld(Packet packet)
        {
            WowPacketParser.Parsing.Parsers.MovementHandler.CurrentMapId = (uint)packet.ReadInt32<MapId>("Map");
            var pos = packet.ReadVector4("Position");
            packet.ReadUInt32("Reason");
            packet.ReadVector3("MovementOffset");

            if (Storage.CurrentActivePlayer != null &&
               !Storage.CurrentActivePlayer.IsEmpty() &&
                Storage.Objects.ContainsKey(Storage.CurrentActivePlayer))
            {
                WoWObject player = Storage.Objects[Storage.CurrentActivePlayer].Item1;
                player.Movement.Position.X = pos.X;
                player.Movement.Position.Y = pos.Y;
                player.Movement.Position.Z = pos.Z;
                player.Movement.Orientation = pos.O;
            }

            Storage.AddObservationTimeBeforeCleanup(packet.Time);
            Storage.ClearDataOnMapChange();
            packet.AddSniffData(StoreNameType.Map, (int)WowPacketParser.Parsing.Parsers.MovementHandler.CurrentMapId, "NEW_WORLD");
        }

        [Parser(Opcode.SMSG_ON_MONSTER_MOVE, ClientVersionBuild.V3_4_3_51505)]
        public static void HandleOnMonsterMove(Packet packet)
        {
            WowGuid guid = packet.ReadPackedGuid128("MoverGUID");
            var pos = packet.ReadVector3("Position");

            Unit obj = null;
            ServerSideMovement monsterMove = null;
            if (Storage.Objects != null && Storage.Objects.ContainsKey(guid))
            {
                obj = Storage.Objects[guid].Item1 as Unit;
                obj.Movement.HasWpsOrRandMov = true;
                monsterMove = new ServerSideMovement();
            }

            ReadMovementMonsterSpline(monsterMove, packet, pos, "MovementMonsterSpline");

            if (monsterMove != null)
            {
                if (guid == Storage.CurrentActivePlayer)
                    Storage.CurrentMoveSplineExpireTime = packet.UnixTimeMs + (long)monsterMove.MoveTime;

                if (Settings.SaveTransports || (monsterMove.TransportGuid == null || monsterMove.TransportGuid.IsEmpty()))
                    obj.AddWaypoint(monsterMove, pos, packet.Time);
            }
        }
    }
}
