using System;
using static System.Console;

namespace Generic
{
    class test
    {
        static void Main(string[] args)
        {            
            Calculator<int> cacul = new Calculator<int>();

            WriteLine(cacul.Sum(13, 45, Calculator<int>.OP.Add));

            Calculator<float> cacul2 = new Calculator<float>();

            WriteLine(cacul2.Sum(13.7, 4.5, Calculator<float>.OP.Add));
        }
    }
}