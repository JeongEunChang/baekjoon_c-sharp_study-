using System;
using static System.Console;

namespace study
{
    class Copyright
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] str = input.Split(' ');

            int A = int.Parse(str[0]);
            int B = int.Parse(str[1]);

            int Result = (A * (B - 1)) + 1;

            WriteLine(Result);
        }
    }
}