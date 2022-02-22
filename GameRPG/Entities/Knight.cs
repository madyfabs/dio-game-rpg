

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
            return this.Name + " Atacou com a espadinha!";
        }


    }
}
