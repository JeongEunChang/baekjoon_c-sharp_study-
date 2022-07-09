using System;
using static System.Console;

namespace study
{
    class AIClock
    {
        static int timesum = 0;

        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] nowtime = input.Split(' ');

            int addtime = Convert.ToInt32(ReadLine());

            int hour = Convert.ToInt32(nowtime[0]);
            int minute = Convert.ToInt32(nowtime[1]);
            int second = Convert.ToInt32(nowtime[2]);

            timesum = (hour * 3600) + (minute * 60) + second;
            timesum += addtime;

            hour = timesum / 3600;
            timesum %= 3600;
            minute = timesum / 60;
            timesum %= 60;
            second = timesum;

            if (hour >= 24)
                hour %= 24;

            WriteLine("{0} {1} {2}", hour, minute, second);
            
        }
    }
}