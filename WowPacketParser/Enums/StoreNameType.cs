using System;

namespace WowPacketParser.Enums
{
    /*public enum StoreNameType
    {
        None,
        Spell,
        Map,
        LFGDungeon,
        Battleground,
        Unit,
        GameObject,
        Item,
        Quest,
        QuestObjective,
        QuestGreeting,
        Opcode, // Packet
        PageText,
        NpcText,
        Gossip,
        Zone,
        Area,
        AreaTrigger,
        Phase,
        Player,
        Currency,
        Achievement
    }*/
    public enum StoreNameType
    {
        None = 1,
        Spell = 2,
        Map = 3,
        LFGDungeon = 4,
        Battleground = 5,
        Unit = 6,
        GameObject = 7,
        Item = 8,
        Quest = 9,
        QuestObjective = 10,
        QuestGreeting = 11,
        Opcode = 12, // Packet
        PageText = 13,
        NpcText = 14,
        Gossip = 15,
        Zone = 16,
        Area = 17,
        AreaTrigger = 18,
        Phase = 19,
        Player = 20,
        Currency = 21,
        Achievement = 22
    }

    /*
    'None',
    'Spell',
    'Map',
    'LFGDungeon'
    ,'Battleground'
    ,'Unit',
    'GameObject',
    'CreatureDifficulty'
    ,'Item'
    ,'Quest',
    'Opcode',
    'PageText',
    'NpcText',
    'BroadcastText',
    'Gossip','Zone',
    'Area',
    'AreaTrigger',
    'Phase',
    'Player',
    'Achievement'

    */
    public static class StoreName
    {
        public static StoreNameType ToEnum<T>() where T : IId
        {
            if (typeof (T) == typeof (SpellId))
                return StoreNameType.Spell;
            if (typeof (T) == typeof (MapId))
                return StoreNameType.Map;
            if (typeof (T) == typeof (LFGDungeonId))
                return StoreNameType.LFGDungeon;
            if (typeof (T) == typeof (BgId))
                return StoreNameType.Battleground;
            if (typeof (T) == typeof (UnitId))
                return StoreNameType.Unit;
            if (typeof (T) == typeof (GOId))
                return StoreNameType.GameObject;
            if (typeof (T) == typeof (ItemId))
                return StoreNameType.Item;
            if (typeof (T) == typeof (QuestId))
                return StoreNameType.Quest;
            if (typeof (T) == typeof (ZoneId))
                return StoreNameType.Zone;
            if (typeof (T) == typeof (AreaId))
                return StoreNameType.Area;
            if (typeof (T) == typeof (CurrencyId))
                return StoreNameType.Currency;
            if (typeof (T) == typeof (AchievementId))
                return StoreNameType.Achievement;

            throw new ArgumentOutOfRangeException(typeof(T).ToString());
        }
    }

    public interface IId { }

    public struct SpellId :  IId { }
    public struct MapId : IId { }
    public struct LFGDungeonId : IId { }
    public struct BgId : IId { }
    public struct UnitId : IId { }
    public struct GOId : IId { }
    public struct ItemId : IId { }
    public struct QuestId : IId { }
    public struct ZoneId : IId { }
    public struct AreaId : IId { }
    public struct CurrencyId : IId { }
    public struct AchievementId : IId { }

}
