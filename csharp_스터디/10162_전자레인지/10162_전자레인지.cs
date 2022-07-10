using System;
using static System.Console;

namespace study
{
    class MicrowaveOven
    {
        static void Main(string[] args)
        {
            int TimeInput = int.Parse(ReadLine());
            int A = 0;
            int B = 0;
            int C = 0;

            if (TimeInput % 10 != 0)
            {
                WriteLine(-1);
                return;
            }

            else
            {
                if (TimeInput >= 300)
                {
                    A = TimeInput / 300;
                    TimeInput %= 300; 
                }

                if (TimeInput >= 60)
                {
                    B = TimeInput / 60;
                    TimeInput %= 60;
                }

                    C = TimeInput / 10;
            }

            WriteLine("{0} {1} {2}", A, B, C);
        }
    }
}