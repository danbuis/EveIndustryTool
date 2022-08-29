using System;

namespace EveIndustryTool.Data
{
    public class BlueprintLine
    {
        public int typeID { get; set; }
        public int activityID { get; set; }
        public int materialTypeID { get; set; }
        public int quantity { get; set; }

        public BlueprintLine(int type, int activty, int materialType, int quantity)
        {
            this.typeID = type;
            this.activityID = activty;
            this.materialTypeID = materialType;
            this.quantity = quantity;
        }
    }
}
