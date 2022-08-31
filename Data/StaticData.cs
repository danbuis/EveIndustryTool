using EveIndustryTool.Models;

namespace EveIndustryTool.Data
{
    public class StaticData
    {
        public List<BlueprintLine> BlueprintLines { get; } = BuildBlueprintList();

        public Dictionary<int, Item> ItemData { get; } = BuildItemData();

        public string MapIntToItemName(int inputID)
        {
            //Console.WriteLine("checking " + inputID);
            if (ItemData.ContainsKey(inputID))
            {
                return ItemData[inputID].name;
            }
            else
            {
                return "Not Found : " + inputID;
            }
        }

        private static List<BlueprintLine> BuildBlueprintList()
        {
            List<BlueprintLine> parts = new List<BlueprintLine>();
            using (var reader = new StreamReader("Data/Blueprints.csv"))
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();

                    List<string> fields = line.Split(",").ToList();
                    //Console.WriteLine(line);
                    BlueprintLine bpLine = new BlueprintLine(
                        Int32.Parse(fields[0]),
                        Int32.Parse(fields[1]),
                        Int32.Parse(fields[2]),
                        Int32.Parse(fields[3])
                    );
                    if (bpLine.activityID == 1)
                    {
                        parts.Add(bpLine);
                    }
                }
            return parts;
        }

        private static Dictionary<int, Item> BuildItemData()
        {
            Dictionary<int, Item> items = new Dictionary<int, Item>();
            using (var reader = new StreamReader("Data/ItemData.csv"))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    List<string> fields = line.Split(",").ToList();
                    //Console.Write(line);
                    Item item = new Item(
                        Int32.Parse(fields[0]),
                        Int32.Parse(fields[1]),
                        fields[2],
                        fields[3],
                        fields[4],
                        Int32.Parse(fields[5]),
                        0
                    );
                    items.Add(item.typeID, item);
                }
            return items;
        }
    }
}