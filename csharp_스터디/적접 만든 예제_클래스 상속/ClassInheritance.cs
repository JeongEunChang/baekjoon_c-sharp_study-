using System;
using static System.Console;

namespace study
{
    public class Character
    {
        public int HP;
        public int STR = 10;
        public int DEF;

        public int GetSTR()
        {
            return STR;
        }
    }

    public class Acher : Character
    {
        int a = GetSTR();
        public int GetHP()
        {
            HP = GetSTR();
            return HP;
        }
    }

    class ClassInheritance
    {
        static void Main(string[] args)
        {


        }
    }
}