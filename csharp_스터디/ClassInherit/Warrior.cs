using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherit
{
    internal class Warrior : Character
    {
        public Warrior()
        {
            HP = 200;
            STR = 120;
            DEF = 100;
        }
        public int GetHP()
        {
            return HP;
        }

        public int GetSTR()
        {
            return STR;
        }

        public int GetDEF()
        {
            return DEF;
        }

        public override string CanUseWeapon()
        {
            return "Sword";
        }
    }
}
