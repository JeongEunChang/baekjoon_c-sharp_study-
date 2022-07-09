using System;
using static System.Console;

namespace study
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string Input = ReadLine();
            int FCount = 0;
            int LCount = Input.Length - 1;
            int Pivot = (Input.Length / 2) - 1;

            if (Input.Length == 1)
            {
                WriteLine(1);
                return;
            }

            while (FCount < LCount)
            {
                if (Input[FCount] != Input[LCount])
                {
                    WriteLine(0);
                    break;
                }

                if (FCount == Pivot)
                    WriteLine(1);

                FCount++;
                LCount--;
            }
        }
    }
}