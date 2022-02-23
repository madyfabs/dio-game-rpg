namespace GameRPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Type, int HP, int MP, Item item)
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
            if (this.MP - 4 >= 0)
            {
                this.MP -= 4;
                return this.Name + $" Utilizou a arte ninja junto com {this.item.Name}! Causou: {this.item.Damage + 2} de dano!";
            }
            else
            {
                this.MP += 2;
                return this.Name + " Está sem MP! Recarregando...";
            }

        }

    }
}
