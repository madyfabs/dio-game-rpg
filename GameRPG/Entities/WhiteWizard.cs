namespace GameRPG.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string Type, int HP, int MP, Item item)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
            this.item = item;
        }

        public override string Attack()
        {
            if (this.MP - 15 >= 0)
            {
                this.MP -= 15;
                return this.Name + $" Amplificou sua magia com {this.item.Name}! Causou: {this.item.Damage + 7} de dano!";
            }
            else
            {
                this.MP += 5;
                return this.Name + " Está sem MP! Recarregando...";
            }

        }

    }
}
