using System;
using static System.Console;

namespace study
{
    class DiceGame
    {
        static void Main(string[] args)
        {
            int RoundNum;
            int A_Life = 100;
            int B_Life = 100;

            RoundNum = int.Parse(ReadLine());

            for (int i = 0; i < RoundNum; i++)
            {
                int A, B;
                string Input;
                string[] tmpinput;

                Input = ReadLine();
                tmpinput = Input.Split(' ');
                A = int.Parse(tmpinput[0]);
                B = int.Parse(tmpinput[1]);

                if (A > B)
                {
                    B_Life -= A;
                }

                else if (A < B)
                {
                    A_Life -= B;
                }
            }

            WriteLine(A_Life);
            WriteLine(B_Life);
        }
    }
}