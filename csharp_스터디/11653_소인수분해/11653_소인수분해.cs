using System;
using static System.Console;

namespace study
{
    class LeastCommonMultiple
    {
        static void Main(string[] args)
        {
            int input = int.Parse(ReadLine());
            int Count = 2;
            int num = input;

            while (num != 1)
            {
                if ((num % Count == 0))
                {
                    WriteLine(Count);
                    num /= Count;
                    Count = 2;
                }

                else
                    Count++;
            }
        }
    }
}