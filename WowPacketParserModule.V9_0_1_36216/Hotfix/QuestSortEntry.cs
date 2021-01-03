using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.QuestSort, HasIndexInData = false)]
    public class QuestSortEntry
    {
        public string SortName { get; set; }
        public sbyte UiOrderIndex { get; set; }
    }
}
