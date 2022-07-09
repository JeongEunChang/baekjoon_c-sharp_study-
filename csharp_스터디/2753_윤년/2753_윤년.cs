using System;
using static System.Console;

namespace study
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                WriteLine(1);

            else
                WriteLine(0);
        }
    }
}