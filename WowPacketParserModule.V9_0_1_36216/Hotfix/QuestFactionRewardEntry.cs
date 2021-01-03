using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.QuestFactionReward, HasIndexInData = false)]
    public class QuestFactionRewardEntry
    {
        [HotfixArray(10)]
        public short[] Difficulty { get; set; }
    }
}
