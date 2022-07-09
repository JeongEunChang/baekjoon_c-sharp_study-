using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherit
{
    internal class Magician : Character
    {
        public Magician()
        {
            HP = 80;
            STR = 50;
            DEF = 30;
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
            return "Stick";
        }
    }
}
