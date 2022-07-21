using System;
using static System.Console;

namespace Delegate
{
    class test
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            WriteLine(calculator.);

            Calculator<float> cacul2 = new Calculator<float>();

            WriteLine(cacul2.Sum(13.7, 4.5, Calculator<float>.OP.Add));
        }
    }
}