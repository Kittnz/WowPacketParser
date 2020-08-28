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
            var characterInventoryRows = new RowList<CharacterInventory>();
            var characterItemInstaceRows = new RowList<CharacterItemInstance>();
            Dictionary<int, uint> accountIdDictionary = new Dictionary<int, uint>();
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
                if (accountIdDictionary.ContainsKey(player.UnitData.PlayerAccount))
                    row.Data.Account = "@ACCID+" + accountIdDictionary[player.UnitData.PlayerAccount];
                else
                {
                    uint id = (uint)accountIdDictionary.Count;
                    accountIdDictionary.Add(player.UnitData.PlayerAccount, id);
                    row.Data.Account = "@ACCID+" + id;
                }

                row.Data.Name = Settings.RandomizePlayerNames ? GetRandomString(8) : StoreGetters.GetName(objPair.Key);
                row.Data.Race = player.UnitData.RaceId;
                row.Data.Class = player.UnitData.ClassId;
                row.Data.Gender = player.UnitData.Sex;
                row.Data.Level = (uint)player.UnitData.Level;
                row.Data.XP = (uint)player.UnitData.PlayerExperience;
                row.Data.Money = (uint)player.UnitData.PlayerMoney;
                row.Data.PlayerBytes = player.UnitData.PlayerBytes1;
                row.Data.PlayerBytes2 = player.UnitData.PlayerBytes2;
                row.Data.PlayerFlags = (uint)player.UnitData.PlayerFlags;
                row.Data.PositionX = player.OriginalMovement.Position.X;
                row.Data.PositionY = player.OriginalMovement.Position.Y;
                row.Data.PositionZ = player.OriginalMovement.Position.Z;
                row.Data.Orientation = player.OriginalMovement.Orientation;
                row.Data.Map = player.Map;
                row.Data.Health = (uint)player.UnitData.CurHealth;
                row.Data.Power1 = (uint)player.UnitData.CurMana;

                for (int i = 0; i < 38; i++)
                {
                    int itemId = 0;

                    UpdateField value;
                    if (player.UpdateFields.TryGetValue(Enums.Version.UpdateFields.GetUpdateField(PlayerField.PLAYER_VISIBLE_ITEM) + i, out value))
                    {
                        itemId = value.Int32Value;

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

                characterRows.Add(row);

                if (maxDbGuid < player.DbGuid)
                    maxDbGuid = player.DbGuid;
            }

            var characterDelete = new SQLDelete<CharacterTemplate>(Tuple.Create("@PGUID+0", "@PGUID+" + maxDbGuid));
            result.Append(characterDelete.Build());
            var characterSql = new SQLInsert<CharacterTemplate>(characterRows, false);
            result.Append(characterSql.Build());
            result.AppendLine();

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

            if (Settings.SqlTables.character_movement)
            {
                var movementRows = new RowList<CharacterMovement>();
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

                        Row<CharacterMovement> row = new Row<CharacterMovement>();
                        row.Data.Guid = "@PGUID+" + player.DbGuid;
                        row.Data.MoveFlags = movement.MoveFlags;
                        row.Data.MoveTime = movement.MoveTime;
                        row.Data.PositionX = movement.Position.X;
                        row.Data.PositionY = movement.Position.Y;
                        row.Data.PositionZ = movement.Position.Z;
                        row.Data.Orientation = movement.Position.O;
                        row.Data.Opcode = Opcodes.GetOpcodeName(movement.Opcode, movement.OpcodeDirection);
                        row.Data.UnixTimeMs = (ulong)Utilities.GetUnixTimeMsFromDateTime(movement.Time);
                        movementRows.Add(row);
                    }
                }

                var movementSql = new SQLInsert<CharacterMovement>(movementRows, false);
                result.Append(movementSql.Build());
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
