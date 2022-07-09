using System;
using static System.Console;
using ClassInherit;

namespace study
{
    class test
    {
        static void Main(string[] args)
        {
            Acher acher = new Acher();
            Warrior warrior = new Warrior();
            Magician magician = new Magician();

            WriteLine(acher.GetHP());
            WriteLine(warrior.GetHP());
            WriteLine(magician.GetHP());
            WriteLine(acher.CanUseWeapon());
            WriteLine(warrior.CanUseWeapon());
            WriteLine(magician.CanUseWeapon());

        }
    }
}