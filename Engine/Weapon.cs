namespace Engine
{
    public class Weapon : Item
    {
       
        public int MinimumDamage { get; set; }  // Propertis
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int price) : base(id, name, namePlural, price)  // Constructor from Items
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
