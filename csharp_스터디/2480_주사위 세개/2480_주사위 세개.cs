using System;
using static System.Console;

namespace study
{
    class Dice3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] num = input.Split(' ');
            int Highest = 0;
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            int C = int.Parse(num[2]);

            if (Highest < A)
                Highest = A;
            
            if (Highest < B)
                Highest = B;

            if (Highest < C)
                Highest = C;


            if ((num[0] == num[1]) && (num[0] == num[2])) // 3개 모두 같을 때
            {
                WriteLine(10000 + (int.Parse(num[0]) * 1000));
            }

            else if ((num[0] == num[1]) || (num[0] == num[2]) || (num[1] == num[2])) // 2개 같을 때
            {
                if ((num[0] == num[1]) || (num[0] == num[2]))
                {
                    WriteLine(1000 + (int.Parse(num[0]) * 100));
                }

                else if (num[1] == num[2])
                {
                    WriteLine(1000 + (int.Parse(num[1]) * 100));
                }
            }

            else
            {
                WriteLine(Highest * 100);
            }
        }
    }
}