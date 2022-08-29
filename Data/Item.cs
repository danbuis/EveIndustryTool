using System;

namespace EveIndustryTool.Data
{
    public class Item
    {
        public int typeID { get; set; }
        public int groupID { get; set; }
        public string name { get; set; }
        public string mass { get; set; }
        public string volume { get; set; }
        public int portion { get; set; }
        public int graphicID { get; set; }

        public Item(int type, int group, string name, string mass, string volume, int portion, int graphics)
        {
            this.typeID = type;
            this.groupID = group;
            this.name = name;
            this.mass = mass;
            this.volume = volume;
            this.portion = portion;
            this.graphicID = graphics;
        }
    }
}
