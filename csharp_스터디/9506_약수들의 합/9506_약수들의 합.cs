using System;
using static System.Console;
using static System.Array;

namespace study
{
    class SumOfDivisor
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Input = int.Parse(ReadLine());
                int Sum = 0;
                int Count = 1;

                if (Input == -1)
                {
                    break;
                }

                while (Count != Input)
                {
                    if (Input % Count == 0)
                    {
                        Sum += Count;
                    }
                    
                    Count++;
                }

                if (Sum == Input)
                {
                    Write("{0} = ", Input);

                    for (int j = 1; j < Count; j++)
                    {
                        if (j == 1)
                        {
                            Write("{0}", j);
                        }

                        else if (Input % j == 0)
                        {
                            Write(" + {0}", j);
                        }
                    }
                    WriteLine();
                }

                else if (Sum != Input)
                {
                    WriteLine("{0} is NOT perfect.", Input);
                }
            }
        }
    }
}