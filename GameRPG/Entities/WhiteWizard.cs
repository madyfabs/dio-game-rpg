namespace GameRPG.Entities
{
    internal class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string Type, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {
            if (this.MP - 15 >= 0)
            {
                this.MP -= 15;
                return this.Name + " Lançou Magia Apocalíptica!";
            }
            else
            {
                this.MP += 6;
                return this.Name + " Está sem MP! Recarregando...";
            }

        }

    }
}
