using System;
using static System.Console;

namespace study
{
    class MultipleAndFactor


    {
        static void Main(string[] args)
        {

            while (true)
            {
                string Input = ReadLine();
                string[] tmp = Input.Split(' ');
                int A = int.Parse(tmp[0]);
                int B = int.Parse(tmp[1]);

                if (A == 0 && B == 0)
                {
                    break;
                }

                else if (B % A == 0)
                {
                    WriteLine("factor");
                }

                else if (A % B == 0)
                {
                    WriteLine("multiple");
                }

                else
                {
                    WriteLine("neither");
                }
            }
        }
    }
}