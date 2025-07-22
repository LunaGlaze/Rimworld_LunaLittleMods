using RimFridge;

namespace LunaCompressedRimfridge
{
    public class RimFridge_BuildingDefaultMaxPerCell : RimFridge_Building
    {
        public override void PostMake()
        {
            base.PostMake();
            RaiseMaxItemsInCellBy((byte)def.building.maxItemsInCell);
        }
    }
}