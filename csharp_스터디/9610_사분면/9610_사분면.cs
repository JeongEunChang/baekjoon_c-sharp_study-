using System;
using static System.Console;

namespace study
{
    class Quadrant
    {
        static void Main(string[] args)
        {
            int InputCount = int.Parse(ReadLine());
            float[,] Dots = new float[1000, 2];
            int Q1 = 0;
            int Q2 = 0;
            int Q3 = 0;
            int Q4 = 0;
            int AXIS = 0;

            for (int i = 0; i < InputCount; i++)
            {
                string Input = ReadLine();
                string[] tmp = Input.Split(' ');

                for (int j = 0; j < tmp.Length; j++)
                {
                    Dots[i, j] = float.Parse(tmp[j]);
                }
            }

            for (int i = 0; i < InputCount; i++)
            {
                if (Dots[i, 0] == 0 || Dots[i, 1] == 0)
                {
                    AXIS++;
                }

                else if (Dots[i, 0] > 0 && Dots[i, 1] > 0)
                {
                    Q1++;
                }

                else if (Dots[i, 0] < 0 && Dots[i, 1] > 0)
                {
                    Q2++;
                }

                else if (Dots[i, 0] < 0 && Dots[i, 1] < 0)
                {
                    Q3++;
                }

                else if (Dots[i, 0] > 0 && Dots[i, 1] < 0)
                {
                    Q4++;
                }
            }

            WriteLine("Q1: {0}", Q1);
            WriteLine("Q2: {0}", Q2);
            WriteLine("Q3: {0}", Q3);
            WriteLine("Q4: {0}", Q4);
            WriteLine("AXIS: {0}", AXIS);
        }
    }
}