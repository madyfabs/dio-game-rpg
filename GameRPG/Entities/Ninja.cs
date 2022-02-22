namespace GameRPG.Entities
{
    internal class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Type, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Shurikens!";
        }

    }
}
