using System;
using static System.Console;

namespace study
{
    class FindingPlaaceToLying
    {
        static void Main(string[] args)
        {
            int LineInput = int.Parse(ReadLine());
            bool[,] Array = new bool[103, 103];
            int VerticalCount = 0;
            int HorizontalCount = 0;


            for (int i = 0; i < LineInput; i++)
            {
                string Input = ReadLine();

                for (int j = 0; j < LineInput; j++)
                {
                    if (Input[j] == '.')
                        Array[i, j] = true;
                }
            }

            for (int i = 0; i < LineInput; i++)
            {
                int SameCountV = 0;
                int SameCountH = 0;
                int FalseCountV = 0;
                int FalseCountH = 0;

                for (int j = 0; j < LineInput; j++)
                {
                    if (Array[i, j] == true)
                        SameCountH++;

                    else if (Array[i, j] == false)
                    {
                        SameCountH = 0;
                    }

                    if (SameCountH == 2)
                    {
                        HorizontalCount++;
                    }
                }

                for (int j = 0; j < LineInput; j++)
                {
                    if (Array[j, i] == true)
                        SameCountV++;

                    else if (Array[j, i] == false)
                    {
                        SameCountV = 0;
                    }

                    if (SameCountV == 2)
                    {
                        VerticalCount++;
                    }
                }
            }
            

            WriteLine("{0} {1}", HorizontalCount, VerticalCount);
        }
    }
}