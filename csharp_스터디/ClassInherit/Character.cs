using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherit
{
    abstract class Character
    {
        protected int HP = 0;
        protected int STR = 0;
        protected int DEF = 0;

        public abstract string CanUseWeapon();
    }
}
