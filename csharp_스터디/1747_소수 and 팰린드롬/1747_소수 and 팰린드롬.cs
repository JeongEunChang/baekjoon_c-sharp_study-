using System;
using static System.Console;
using static System.Array;

namespace study
{
    class PrimeNumberAndPalindrome
    {
        static void Main(string[] args)
        {
            string N = ReadLine();
            int Count = int.Parse(N);
            bool IsPalindrome = false;


            while (Count < 10)
            {
                if (Count != 1)
                {
                    if (Count == 2)
                    {
                        WriteLine(Count);
                        return;
                    }

                    for (int k = 2; k < Count; k++)
                    {
                        if (Count % k == 0)
                        {
                            break;
                        }

                        if (k == Count - 1)
                        {
                            WriteLine(Count);
                            return;
                        }

                    }
                }
                
                Count++;
            }

            while (true)
            {
                for (int j = 0; j < Count.ToString().Length / 2; j++)
                {
                    if (Count.ToString()[j] != Count.ToString()[Count.ToString().Length - j - 1])
                    {
                        break;
                    }

                    if (j == (Count.ToString().Length / 2) - 1)
                        IsPalindrome = true;
                }

                if (IsPalindrome)
                {
                    for (int k = 2; k < Count; k++)
                    {
                        if (Count % k == 0)
                        {
                            break;
                        }

                        if (k == Count - 1)
                        {
                            WriteLine(Count);
                            return;
                        }

                    }
                }

                Count++;
                IsPalindrome = false;
            }
        }
    }
}