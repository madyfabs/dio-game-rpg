namespace GameRPG.Entities
{
    public  class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string Type, int HP, int MP, Item item)
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
            if (this.MP - 17 >= 0)
            {
                this.MP -= 17;
                return this.Name + $" Aumentou, e muito, sua magia apocalíptica usando {this.item.Name}! Causou: {this.item.Damage + 9} de dano!";
            }
            else
            {
                this.MP += 6;
                return this.Name + " Está sem MP! Recarregando...";
            }
            
        }

    }
}
