using System;
using static System.Console;

namespace study
{
    class PlusCycle

    {
        static void Main(string[] args)
        {
            string N = ReadLine();
            int Number = int.Parse(N);
            int Count = 0;
            int tmp = 0;

            while (true)
            {
                tmp = 0;
                Count++;

                for (int i = 10; i < 1000; i*=10)
                {
                    tmp += (Number % i) / (i / 10);
                }

                Number = (Number % 10) * 10 + (tmp % 10);

                if (int.Parse(N) == Number)
                {
                    break;
                }
            }

            WriteLine(Count);
        }
    }
}