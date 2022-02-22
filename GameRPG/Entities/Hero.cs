using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Entities
{
    internal class Hero
    {

        public Hero (string Name, int Level, string Type)
        {

            this.Name = Name;
            this.Level = Level;
            this.Type = Type;

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return this.Name + " "+this.Level + " "+this.Type;
        }



    }
}
