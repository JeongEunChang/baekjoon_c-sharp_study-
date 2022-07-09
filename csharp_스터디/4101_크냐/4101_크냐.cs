using System;
using static System.Console;

namespace study
{
    class IsBig
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string Input = ReadLine();
                string[] tmpInput = Input.Split(' ');
                int a = int.Parse(tmpInput[0]);
                int b = int.Parse(tmpInput[1]);

                if (a == 0 && b == 0)
                    break;

                else if (a > b)
                    WriteLine("Yes");

                else
                    WriteLine("No");
            }
        }
    }
}