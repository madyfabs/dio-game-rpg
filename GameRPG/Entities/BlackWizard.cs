using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Entities
{
    internal class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string Type, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack()
        {   
            if (this.MP - 17 >= 0)
            {
                this.MP -= 17;
                return this.Name + " Lançou Magia Apocalíptica!";
            }
            else
            {
                this.MP += 8;
                return this.Name + " Está sem MP! Recarregando...";
            }
            
        }

    }
}
