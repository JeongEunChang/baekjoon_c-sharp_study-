using System;
using static System.Console;

namespace study
{
    class StringRepeat
    {
        static void Main(string[] args)
        {
            int Times = int.Parse(ReadLine());

            for (int i = 0; i < Times; i++)
            {
                string input = ReadLine();
                string[] str = input.Split(' ');
                int num = int.Parse(str[0]);

                for (int j = 0; j < str[1].Length; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        Write(str[1][j]);
                    }
                }

                WriteLine();
            }
            
        }
    }
}