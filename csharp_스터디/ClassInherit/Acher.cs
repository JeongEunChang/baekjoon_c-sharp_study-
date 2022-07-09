using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherit
{
    internal class Acher : Character
    {
        public Acher()
        {
            HP = 100;
            STR = 80;
            DEF = 50;
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
            return "Bow";
        }
    }
}
