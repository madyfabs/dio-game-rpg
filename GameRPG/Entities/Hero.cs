namespace GameRPG.Entities
{
    public abstract class Hero
    {   
        public Hero() { }

        public Hero (string Name, int Level, string Type, int HP, int MP, Item item)
        {

            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
            this.item = item;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Item item { get; set; }

        public override string ToString()
        {
            return this.Name + " "+this.Level + " "+this.Type+ " "+this.HP+ " "+this.MP;
        }

        public virtual  string Attack() {
            return " ";
        }


    }
}
