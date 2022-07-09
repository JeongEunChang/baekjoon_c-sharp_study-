using System;
using static System.Console;

namespace study
{
    class OvenClock
    {
        static int timesum = 0;

        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] nowtime = input.Split(' ');

            int addtime = Convert.ToInt32(ReadLine());

            int hour = Convert.ToInt32(nowtime[0]);
            int minute = Convert.ToInt32(nowtime[1]);

            timesum = (hour * 60) + minute;
            timesum += addtime;

            hour = timesum / 60;
            timesum %= 60;
            minute = timesum;

            if (hour >= 24)
                hour %= 24;

            WriteLine("{0} {1}", hour, minute);

        }
    }
}