using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 적접_만든_예제_클래스_상속
{
    public class Character
    {
        protected int HP = 0;;
        public int STR = 0;;
        protected int DEF;

        public int GetHP()
        {
            return HP;
        }
    }
}
