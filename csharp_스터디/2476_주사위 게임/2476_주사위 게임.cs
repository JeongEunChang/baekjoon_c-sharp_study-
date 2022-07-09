using System;
using static System.Console;

namespace study
{
    class DiceGame
    {
        static int MoneyCacul(int Dice1, int Dice2, int Dice3)
        {
            int sum = 0;
            int a;
            int b;
            int Highest = 0;

            if (Dice1 == Dice2 && Dice2 == Dice3)
            {
                sum = 10000 + (Dice1 * 1000);
            }

            else if (Dice1 == Dice2 || Dice2 == Dice3 || Dice1 == Dice3)
            {
                if (Dice1 == Dice2 || Dice1 == Dice3)
                {
                    sum = 1000 + (Dice1 * 100);
                }

                else if (Dice2 == Dice3)
                {
                    sum = 1000 + (Dice2 * 100);
                }
            }

            else
            {
                if (Dice1 > Highest)
                    Highest = Dice1;

                if (Dice2 > Highest)
                    Highest = Dice2;

                if (Dice3 > Highest)
                    Highest = Dice3;

                sum = Highest * 100;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int PeopleInput = int.Parse(ReadLine());
            int MostMoney = 0;

            for (int i = 0; i < PeopleInput; i++)
            {
                string Input = ReadLine();
                string[] DiceInput = Input.Split(' ');
                int Dice1 = int.Parse(DiceInput[0]);
                int Dice2 = int.Parse(DiceInput[1]);
                int Dice3 = int.Parse(DiceInput[2]);

                int tmp = MoneyCacul(Dice1, Dice2, Dice3);

                if (tmp > MostMoney)
                    MostMoney = tmp;
            }

  
            WriteLine(MostMoney);
        }
    }
}