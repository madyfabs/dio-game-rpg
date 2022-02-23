namespace GameRPG.Entities
{
    public class Item
    {
        public Item() { }
        public Item(string Name, int Value, int Damage)
        {
            this.Name = Name;
            this.Value = Value;
            this.Damage = Damage;
        }

        public string Name { get; set; }
        public int Value { get; set; }
        public int Damage { get; set; }
    }
}
