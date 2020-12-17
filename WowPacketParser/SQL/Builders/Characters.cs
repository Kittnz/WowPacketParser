﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WowPacketParser.Enums;
using WowPacketParser.Enums.Version;
using WowPacketParser.Misc;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;

namespace WowPacketParser.SQL.Builders
{
    [BuilderClass]
    public static class Characters
    {
        private static Random random = new Random();
        public static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString.Substring(0, 1) + randomString.Substring(1).ToLower();
        }

        [BuilderMethod]
        public static string CharactersBuilder()
        {
            if (!Settings.SqlTables.characters)
                return string.Empty;

            StringBuilder result = new StringBuilder();
            uint maxDbGuid = 0;
            uint itemGuidCounter = 0;
            var characterRows = new RowList<CharacterTemplate>();
            var characterAddonRows = new RowList<CharacterTemplateAddon>();
            var characterInventoryRows = new RowList<CharacterInventory>();
            var characterItemInstaceRows = new RowList<CharacterItemInstance>();
            var characterAttackLogRows = new RowList<UnitMeleeAttackLog>();
            var characterAttackStartRows = new RowList<CreatureTargetChange>();
            var characterAttackStopRows = new RowList<CreatureTargetChange>();
            var characterTargetChangeRows = new RowList<CreatureTargetChange>();
            var characterAurasUpdateRows = new RowList<CreatureAurasUpdate>();
            var characterValuesUpdateRows = new RowList<CreatureValuesUpdate>();
            var characterSpeedUpdateRows = new RowList<CreatureSpeedUpdate>();
            var characterServerMovementRows = new RowList<ServerSideMovement>();
            var characterServerMovementSplineRows = new RowList<ServerSideMovementSpline>();
            Dictionary<WowGuid, uint> accountIdDictionary = new Dictionary<WowGuid, uint>();
            foreach (var objPair in Storage.Objects)
            {
                if (objPair.Key.GetObjectType() != ObjectType.Player)
                    continue;

                Player player = objPair.Value.Item1 as Player;
                if (player == null)
                    continue;

                if (!player.IsActivePlayer && Settings.SkipOtherPlayers)
                    continue;

                Row<CharacterTemplate> row = new Row<CharacterTemplate>();

                row.Data.Guid = "@PGUID+" + player.DbGuid;
                if (accountIdDictionary.ContainsKey(player.PlayerDataOriginal.WowAccount))
                    row.Data.Account = "@ACCID+" + accountIdDictionary[player.PlayerDataOriginal.WowAccount];
                else
                {
                    uint id = (uint)accountIdDictionary.Count;
                    accountIdDictionary.Add(player.PlayerDataOriginal.WowAccount, id);
                    row.Data.Account = "@ACCID+" + id;
                }

                row.Data.Name = Settings.RandomizePlayerNames ? GetRandomString(8) : StoreGetters.GetName(objPair.Key);
                row.Data.Race = player.UnitDataOriginal.RaceId;
                row.Data.Class = player.UnitDataOriginal.ClassId;
                row.Data.Gender = player.UnitDataOriginal.Sex;
                row.Data.Level = (uint)player.UnitDataOriginal.Level;
                row.Data.XP = player.PlayerDataOriginal.Experience;
                row.Data.Money = player.PlayerDataOriginal.Money;
                row.Data.PlayerBytes = player.PlayerDataOriginal.PlayerBytes1;
                row.Data.PlayerBytes2 = player.PlayerDataOriginal.PlayerBytes2;
                row.Data.PlayerFlags = player.PlayerDataOriginal.PlayerFlags;
                MovementInfo moveData = player.OriginalMovement == null ? player.Movement : player.OriginalMovement;
                if (moveData != null)
                {
                    row.Data.PositionX = moveData.Position.X;
                    row.Data.PositionY = moveData.Position.Y;
                    row.Data.PositionZ = moveData.Position.Z;
                    row.Data.Orientation = moveData.Orientation;
                }
                row.Data.Map = player.Map;
                row.Data.Health = (uint)player.UnitDataOriginal.MaxHealth;
                row.Data.Power1 = (uint)player.UnitDataOriginal.MaxMana;

                PlayerField visibleItemsStart = ClientVersion.AddedInVersion(ClientVersionBuild.V5_4_2_17658) ? PlayerField.PLAYER_VISIBLE_ITEM : PlayerField.PLAYER_VISIBLE_ITEM_1_ENTRYID;
                for (int i = 0; i < 38; i++)
                {
                    int itemId = 0;

                    if (player.UpdateFields == null)
                        break;

                    UpdateField value;
                    if (player.UpdateFields.TryGetValue(Enums.Version.UpdateFields.GetUpdateField(visibleItemsStart) + i, out value))
                    {
                        itemId = Math.Abs(value.Int32Value);

                        // even indexes are item ids, odd indexes are enchant ids
                        if ((itemId != 0) && (i % 2 == 0))
                        {
                            Row<CharacterInventory> inventoryRow = new Row<CharacterInventory>();
                            inventoryRow.Data.Guid = row.Data.Guid;
                            inventoryRow.Data.Bag = 0;
                            inventoryRow.Data.Slot = (uint)i / 2;
                            inventoryRow.Data.ItemGuid = "@IGUID+" + itemGuidCounter;
                            inventoryRow.Data.ItemTemplate = (uint)itemId;
                            characterInventoryRows.Add(inventoryRow);

                            Row<CharacterItemInstance> itemInstanceRow = new Row<CharacterItemInstance>();
                            itemInstanceRow.Data.Guid = "@IGUID+" + itemGuidCounter;
                            itemInstanceRow.Data.ItemEntry = (uint)itemId;
                            itemInstanceRow.Data.OwnerGuid = row.Data.Guid;
                            characterItemInstaceRows.Add(itemInstanceRow);

                            itemGuidCounter++;
                        }
                    }

                    if (row.Data.EquipmentCache.Length > 0)
                        row.Data.EquipmentCache += " ";

                    row.Data.EquipmentCache += itemId;
                }

                if (Settings.SqlTables.characters_addon)
                {
                    Row<CharacterTemplateAddon> addonRow = new Row<CharacterTemplateAddon>();
                    addonRow.Data.Guid = row.Data.Guid;
                    addonRow.Data.DisplayID = (uint)player.UnitDataOriginal.DisplayID;
                    addonRow.Data.MountDisplayId = (uint)player.UnitDataOriginal.MountDisplayID;
                    addonRow.Data.FactionTemplate = (uint)player.UnitDataOriginal.FactionTemplate;
                    addonRow.Data.CurHealth = (uint)player.UnitDataOriginal.CurHealth;
                    addonRow.Data.MaxHealth = (uint)player.UnitDataOriginal.MaxHealth;
                    addonRow.Data.CurMana = (uint)player.UnitDataOriginal.CurMana;
                    addonRow.Data.MaxMana = (uint)player.UnitDataOriginal.MaxMana;
                    if (moveData != null)
                    {
                        addonRow.Data.SpeedWalk = moveData.WalkSpeed;
                        addonRow.Data.SpeedRun = moveData.RunSpeed;
                    }  
                    addonRow.Data.Scale = player.ObjectDataOriginal.Scale;
                    addonRow.Data.BoundingRadius = player.UnitDataOriginal.BoundingRadius;
                    addonRow.Data.CombatReach = player.UnitDataOriginal.CombatReach;
                    addonRow.Data.BaseAttackTime = player.UnitDataOriginal.AttackRoundBaseTime[0];
                    addonRow.Data.RangedAttackTime = player.UnitDataOriginal.RangedAttackRoundBaseTime;
                    addonRow.Data.UnitFlags = player.UnitDataOriginal.Flags;
                    characterAddonRows.Add(addonRow);
                }

                if (Settings.SqlTables.character_attack_log)
                {
                    if (Storage.UnitAttackLogs.ContainsKey(objPair.Key))
                    {
                        foreach (var attack in Storage.UnitAttackLogs[objPair.Key])
                        {
                            Row<UnitMeleeAttackLog> attackRow = new Row<UnitMeleeAttackLog>();
                            attackRow.Data = attack;
                            attackRow.Data.GUID = row.Data.Guid;
                            Storage.GetObjectDbGuidEntryType(attack.Victim, out attackRow.Data.VictimGuid, out attackRow.Data.VictimId, out attackRow.Data.VictimType);
                            attackRow.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(attack.Time);
                            characterAttackLogRows.Add(attackRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_attack_start)
                {
                    if (Storage.UnitAttackStartTimes.ContainsKey(objPair.Key))
                    {
                        foreach (var attack in Storage.UnitAttackStartTimes[objPair.Key])
                        {
                            Row<CreatureTargetChange> attackRow = new Row<CreatureTargetChange>();
                            attackRow.Data.GUID = row.Data.Guid;
                            Storage.GetObjectDbGuidEntryType(attack.victim, out attackRow.Data.VictimGuid, out attackRow.Data.VictimId, out attackRow.Data.VictimType);
                            attackRow.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(attack.time);
                            characterAttackStartRows.Add(attackRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_attack_stop)
                {
                    if (Storage.UnitAttackStopTimes.ContainsKey(objPair.Key))
                    {
                        foreach (var attack in Storage.UnitAttackStopTimes[objPair.Key])
                        {
                            Row<CreatureTargetChange> attackRow = new Row<CreatureTargetChange>();
                            attackRow.Data.GUID = row.Data.Guid;
                            Storage.GetObjectDbGuidEntryType(attack.victim, out attackRow.Data.VictimGuid, out attackRow.Data.VictimId, out attackRow.Data.VictimType);
                            attackRow.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(attack.time);
                            characterAttackStopRows.Add(attackRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_target_change)
                {
                    if (Storage.UnitTargetChanges.ContainsKey(objPair.Key))
                    {
                        foreach (var attack in Storage.UnitTargetChanges[objPair.Key])
                        {
                            Row<CreatureTargetChange> attackRow = new Row<CreatureTargetChange>();
                            attackRow.Data.GUID = row.Data.Guid;
                            Storage.GetObjectDbGuidEntryType(attack.victim, out attackRow.Data.VictimGuid, out attackRow.Data.VictimId, out attackRow.Data.VictimType);
                            attackRow.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(attack.time);
                            characterTargetChangeRows.Add(attackRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_auras_update)
                {
                    if (Storage.UnitAurasUpdates.ContainsKey(objPair.Key))
                    {
                        uint updateId = 0;
                        foreach (var update in Storage.UnitAurasUpdates[objPair.Key])
                        {
                            updateId++;
                            foreach (var aura in update.Item1)
                            {
                                var updateRow = new Row<CreatureAurasUpdate>();
                                updateRow.Data.GUID = row.Data.Guid;
                                updateRow.Data.UpdateId = updateId;
                                updateRow.Data.Slot = aura.Slot;
                                updateRow.Data.SpellId = aura.SpellId;
                                updateRow.Data.VisualId = aura.VisualId;
                                updateRow.Data.AuraFlags = aura.AuraFlags;
                                updateRow.Data.ActiveFlags = aura.ActiveFlags;
                                updateRow.Data.Level = aura.Level;
                                updateRow.Data.Charges = aura.Charges;
                                updateRow.Data.ContentTuningId = aura.ContentTuningId;
                                updateRow.Data.Duration = aura.Duration;
                                updateRow.Data.MaxDuration = aura.MaxDuration;
                                Storage.GetObjectDbGuidEntryType(aura.CasterGuid, out updateRow.Data.CasterGuid, out updateRow.Data.CasterId, out updateRow.Data.CasterType);
                                updateRow.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(update.Item2);
                                characterAurasUpdateRows.Add(updateRow);
                            }
                        }
                    }
                }

                if (Settings.SqlTables.character_values_update)
                {
                    if (Storage.UnitValuesUpdates.ContainsKey(objPair.Key))
                    {
                        foreach (var update in Storage.UnitValuesUpdates[objPair.Key])
                        {
                            var updateRow = new Row<CreatureValuesUpdate>();
                            updateRow.Data = update;
                            updateRow.Data.GUID = row.Data.Guid;
                            characterValuesUpdateRows.Add(updateRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_speed_update)
                {
                    if (Storage.UnitSpeedUpdates.ContainsKey(objPair.Key))
                    {
                        foreach (var update in Storage.UnitSpeedUpdates[objPair.Key])
                        {
                            var updateRow = new Row<CreatureSpeedUpdate>();
                            updateRow.Data = update;
                            updateRow.Data.GUID = row.Data.Guid;
                            characterSpeedUpdateRows.Add(updateRow);
                        }
                    }
                }

                if (Settings.SqlTables.character_chat)
                {
                    foreach (var text in Storage.CharacterTexts)
                    {
                        if (text.Item1.SenderGUID == objPair.Key)
                        {
                            text.Item1.Guid = "@PGUID+" + player.DbGuid;
                            text.Item1.SenderName = row.Data.Name;
                        }
                    }
                }

                if (Settings.SqlTables.character_movement_server)
                {
                    foreach (ServerSideMovementSpline waypoint in player.CombatMovementSplines)
                    {
                        var movementSplineRow = new Row<ServerSideMovementSpline>();
                        movementSplineRow.Data = waypoint;
                        movementSplineRow.Data.GUID = "@PGUID+" + player.DbGuid;
                        characterServerMovementSplineRows.Add(movementSplineRow);
                    }

                    foreach (ServerSideMovement waypoint in player.CombatMovements)
                    {
                        if (waypoint == null)
                            break;

                        var movementRow = new Row<ServerSideMovement>();
                        movementRow.Data = waypoint;
                        movementRow.Data.GUID = "@PGUID+" + player.DbGuid;
                        characterServerMovementRows.Add(movementRow);
                    }
                }

                characterRows.Add(row);

                if (maxDbGuid < player.DbGuid)
                    maxDbGuid = player.DbGuid;
            }

            var characterDelete = new SQLDelete<CharacterTemplate>(Tuple.Create("@PGUID+0", "@PGUID+" + maxDbGuid));
            result.Append(characterDelete.Build());
            var characterSql = new SQLInsert<CharacterTemplate>(characterRows, false);
            result.Append(characterSql.Build());
            result.AppendLine();

            if (Settings.SqlTables.characters_addon)
            {
                var addonDelete = new SQLDelete<CharacterTemplateAddon>(Tuple.Create("@IGUID+0", "@IGUID+" + itemGuidCounter));
                result.Append(addonDelete.Build());
                var addonSql = new SQLInsert<CharacterTemplateAddon>(characterAddonRows, false);
                result.Append(addonSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_active_player)
            {
                var activePlayersRows = new RowList<CharacterActivePlayer>();
                foreach (var itr in Storage.PlayerActiveCreateTime)
                {
                    Row<CharacterActivePlayer> row = new Row<CharacterActivePlayer>();
                    row.Data.Guid = Storage.GetObjectDbGuid(itr.Guid);
                    row.Data.UnixTime = (uint)Utilities.GetUnixTimeFromDateTime(itr.Time);
                    activePlayersRows.Add(row);
                }
                var activePlayersDelete = new SQLDelete<CharacterActivePlayer>(Tuple.Create("@PGUID+0", "@PGUID+" + maxDbGuid));
                result.Append(activePlayersDelete.Build());
                var activePlayersSql = new SQLInsert<CharacterActivePlayer>(activePlayersRows, false);
                result.Append(activePlayersSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_inventory)
            {
                var inventoryDelete = new SQLDelete<CharacterInventory>(Tuple.Create("@IGUID+0", "@IGUID+" + itemGuidCounter));
                result.Append(inventoryDelete.Build());
                var inventorySql = new SQLInsert<CharacterInventory>(characterInventoryRows, false);
                result.Append(inventorySql.Build());
                result.AppendLine();

                var itemInstanceDelete = new SQLDelete<CharacterItemInstance>(Tuple.Create("@IGUID+0", "@IGUID+" + itemGuidCounter));
                result.Append(itemInstanceDelete.Build());
                var itemInstanceSql = new SQLInsert<CharacterItemInstance>(characterItemInstaceRows, false);
                result.Append(itemInstanceSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_movement_client)
            {
                var movementRows = new RowList<ClientSideMovement>();
                foreach (var movement in Storage.PlayerMovements)
                {
                    if (Storage.Objects.ContainsKey(movement.guid))
                    {
                        Player player = Storage.Objects[movement.guid].Item1 as Player;
                        if (player == null)
                            continue;

                        if (Settings.SkipOtherPlayers && !player.IsActivePlayer &&
                           (movement.OpcodeDirection != Direction.ClientToServer))
                            continue;

                        Row<ClientSideMovement> row = new Row<ClientSideMovement>();
                        row.Data.Guid = "@PGUID+" + player.DbGuid;
                        row.Data.MoveFlags = movement.MoveFlags;
                        row.Data.MoveTime = movement.MoveTime;
                        row.Data.Map = movement.Map;
                        row.Data.PositionX = movement.Position.X;
                        row.Data.PositionY = movement.Position.Y;
                        row.Data.PositionZ = movement.Position.Z;
                        row.Data.Orientation = movement.Position.O;
                        row.Data.Opcode = Opcodes.GetOpcodeName(movement.Opcode, movement.OpcodeDirection);
                        row.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(movement.Time);
                        movementRows.Add(row);
                    }
                }

                var movementSql = new SQLInsert<ClientSideMovement>(movementRows, false);
                result.Append(movementSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_movement_server)
            {
                var movementSql = new SQLInsert<ServerSideMovement>(characterServerMovementRows, false, false, "character_movement_server");
                result.Append(movementSql.Build());
                result.AppendLine();

                var movementSplineSql = new SQLInsert<ServerSideMovementSpline>(characterServerMovementSplineRows, false, false, "character_movement_server_spline");
                result.Append(movementSplineSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_attack_log)
            {
                var characterAttackLogSql = new SQLInsert<UnitMeleeAttackLog>(characterAttackLogRows, false, false, "character_attack_log");
                result.Append(characterAttackLogSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_attack_start)
            {
                var characterAttackStartSql = new SQLInsert<CreatureTargetChange>(characterAttackStartRows, false, false, "character_attack_start");
                result.Append(characterAttackStartSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_attack_stop)
            {
                var characterAttackStopSql = new SQLInsert<CreatureTargetChange>(characterAttackStopRows, false, false, "character_attack_stop");
                result.Append(characterAttackStopSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_target_change)
            {
                var characterTargetChangeSql = new SQLInsert<CreatureTargetChange>(characterTargetChangeRows, false, false, "character_target_change");
                result.Append(characterTargetChangeSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_auras_update)
            {
                var characterUpdateSql = new SQLInsert<CreatureAurasUpdate>(characterAurasUpdateRows, false, false, "character_auras_update");
                result.Append(characterUpdateSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_values_update)
            {
                var characterUpdateSql = new SQLInsert<CreatureValuesUpdate>(characterValuesUpdateRows, false, false, "character_values_update");
                result.Append(characterUpdateSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_speed_update)
            {
                var characterUpdateSql = new SQLInsert<CreatureSpeedUpdate>(characterSpeedUpdateRows, false, false, "character_speed_update");
                result.Append(characterUpdateSql.Build());
                result.AppendLine();
            }

            if (Settings.SqlTables.character_chat && !Storage.CharacterTexts.IsEmpty())
            {
                var characterChatDelete = new SQLDelete<CharacterChat>(Tuple.Create("@PGUID+0", "@PGUID+" + maxDbGuid));
                result.Append(characterChatDelete.Build());
                foreach (var text in Storage.CharacterTexts)
                {
                    if (text.Item1.Guid == null)
                    {
                        text.Item1.Guid = "0";
                        if (String.IsNullOrEmpty(text.Item1.SenderName) && !text.Item1.SenderGUID.IsEmpty())
                            text.Item1.SenderName = StoreGetters.GetName(text.Item1.SenderGUID);
                    }
                    if (text.Item1.ChannelName == null)
                        text.Item1.ChannelName = "";
                }
                result.Append(SQLUtil.Compare(Storage.CharacterTexts, SQLDatabase.Get(Storage.CharacterTexts), t => t.SenderName, false));
            }

            return result.ToString();
        }
    }
}
