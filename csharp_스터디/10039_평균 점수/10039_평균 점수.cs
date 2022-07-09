using System;
using static System.Console;

namespace study
{
    class AverageGrade
    {
        static void Main(string[] args)
        {
            int Won = int.Parse(ReadLine());
            int Se = int.Parse(ReadLine());
            int Sang = int.Parse(ReadLine());
            int Sung = int.Parse(ReadLine());
            int Kang = int.Parse(ReadLine());
            int Average = 0;

            if (Won < 40)
                Won = 40;

            if (Se < 40)
                Se = 40;

            if (Sang < 40)
                Sang = 40;

            if (Sung < 40)
                Sung = 40;

            if (Kang < 40)
                Kang = 40;

            Average = (Won + Se + Sang + Sung + Kang) / 5;

            WriteLine(Average);
        }
    }
}