using System;
using static System.Console;

namespace study
{
    class Cute
    {
        static void Main(string[] args)
        {
            int IputCount = int.Parse(ReadLine());
            int CuteCount = 0;
            int NotCuteCOunt = 0;

            for (int i = 0; i < IputCount; i++)
            {
                int Input = int.Parse(ReadLine());

                if (Input == 0)
                {
                    NotCuteCOunt++;
                }

                else if (Input == 1)
                {
                    CuteCount++;
                }
            }

            if (NotCuteCOunt >= CuteCount)
            {
                WriteLine("Junhee is not cute!");
            }

            else
            {
                WriteLine("Junhee is cute!");
            }
        }
    }
}