namespace Engine
{
    public class Item
    {
        public int ID { get; set; }  // Propertis
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int Price { get; set; }  

        public Item(int id, string name, string namePlural, int price)  // Constructor
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
        }

    }
}
