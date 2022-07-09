using System;
using static System.Console;

namespace study
{
    class FourthDot
    {
        static void Main(string[] args)
        {
            int[,] Dot = new int[3, 2];
            int a = 0;
            int b = 0;

            for (int i = 0; i < 3; i++)
            {
                string Input = ReadLine();
                string[] tmpInput = Input.Split(' ');

                for (int j = 0; j < 2; j++)
                {
                    Dot[i, j] = int.Parse(tmpInput[j]);
                }
            }


            if (Dot[0, 0] == Dot[1, 0])
                a = Dot[2, 0];

            else if (Dot[0, 0] == Dot[2, 0])
                a = Dot[1, 0];

            else if (Dot[1, 0] == Dot[2, 0])
                a = Dot[0, 0];


            if (Dot[0, 1] == Dot[1, 1])
                b = Dot[2, 1];

            else if (Dot[0, 1] == Dot[2, 1])
                b = Dot[1, 1];

            else if (Dot[1, 1] == Dot[2, 1])
                b = Dot[0, 1];

            WriteLine(a + " " + b);
        }
    }
}