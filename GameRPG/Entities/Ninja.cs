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
            if (this.MP - 4 >= 0)
            {
                this.MP -= 4;
                return this.Name + " Lançou Magia Apocalíptica!";
            }
            else
            {
                this.MP += 2;
                return this.Name + " Está sem MP! Recarregando...";
            }

        }

    }
}
