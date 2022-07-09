using System;
using static System.Console;

namespace study
{
    class MarsMath
    {
        static float sum = 0;

        static void Main(string[] args)
        {
            int casenum = Convert.ToInt32(ReadLine());

            for (int i = 0; i < casenum; i++)
            {
                string _input = ReadLine();
                string[] input =_input.Split(' ');

                for (int j = 0; j < input.Length; j++)
                {
                    if (j == 0)
                    {
                        sum = float.Parse(input[0]);
                    }

                    if (input[j] == "@")
                    {
                        sum = sum * 3;
                    }

                    else if (input[j] == "%")
                    {
                        sum = sum + 5;
                    }

                    else if (input[j] == "#")
                    {
                        sum = sum - 7;
                    }
                }

                WriteLine("{0:f2}", sum);
            }
        }
    }
}