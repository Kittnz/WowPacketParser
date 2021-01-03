using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V8_0_1_27101.UpdateFields.V8_2_5_31921
{
    public class VisibleItem : IVisibleItem
    {
        public int ItemID { get; set; }
        public ushort ItemAppearanceModID { get; set; }
        public ushort ItemVisual { get; set; }

        public IVisibleItem Clone() { return (IVisibleItem)MemberwiseClone(); }
    }
}

