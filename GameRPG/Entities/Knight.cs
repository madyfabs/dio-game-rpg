namespace GameRPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string Type, int HP, int MP) 
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;   
        }

        public override string Attack()
        {
            if (this.MP - 2 >= 0)
            {
                this.MP -= 2;
                return this.Name + " Lançou Magia Apocalíptica!";
            }
            else
            {
                this.MP += 1;
                return this.Name + " Está sem MP! Recarregando...";
            }

        }

    }
}
