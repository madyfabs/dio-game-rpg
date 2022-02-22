

namespace GameRPG.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string Type) : base(null, 0 , null)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }
    }
}
