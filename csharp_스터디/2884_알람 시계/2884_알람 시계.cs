using System;
using static System.Console;

namespace study
{
    class AlarmClock
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] time = input.Split(' ');
            int hh = int.Parse(time[0]);
            int mm = int.Parse(time[1]);

            mm -= 45;

            if (mm < 0)
            {
                hh--;
                mm = 60 + mm;
            }

            if (hh < 0)
            {
                hh = 23;
            }

            WriteLine("{0} {1}", hh, mm);
        }
    }
}