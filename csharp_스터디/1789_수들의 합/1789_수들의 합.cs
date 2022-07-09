using System;
using static System.Console;

namespace study
{
    class SumOfNumber
    { 


        static void Main(string[] args)
        {
            long input = long.Parse(ReadLine());
            long sum = 0;
            long i = 0;

            while (true)
            {
                i++;
                sum += i;
                
                if (sum == input)
                {
                    break;
                }

                else if (sum > input)
                {
                    i = i - 1;
                    break;
                }

            }

            WriteLine(i);
        }
    }
}