using System;
using static System.Console;

namespace study
{
    class Bowl
    {
        static void Main(string[] args)
        {
            string bowl = ReadLine();
            int heigh = 10;

            for (int i = 1; i < bowl.Length; i++)
            {
                if (bowl[i] == bowl[i - 1])
                {
                    heigh += 5;
                }

                else
                {
                    heigh += 10;
                }
            }

            WriteLine(heigh);
        }
    }
}