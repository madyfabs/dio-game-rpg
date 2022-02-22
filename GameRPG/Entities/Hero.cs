using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Entities
{
    public abstract class Hero
    {   
        public Hero() { }

        public Hero (string Name, int Level, string Type, int HP, int MP)
        {

            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public override string ToString()
        {
            return this.Name + " "+this.Level + " "+this.Type;
        }

        public virtual  string Attack() {
            return "Atacou!";
        }


    }
}
