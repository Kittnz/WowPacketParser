using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.ItemDisenchantLoot, HasIndexInData = false)]
    public class ItemDisenchantLootEntry
    {
        public sbyte Subclass { get; set; }
        public byte Quality { get; set; }
        public ushort MinLevel { get; set; }
        public ushort MaxLevel { get; set; }
        public ushort SkillRequired { get; set; }
        public sbyte ExpansionID { get; set; }
        public byte Class { get; set; }
    }
}
