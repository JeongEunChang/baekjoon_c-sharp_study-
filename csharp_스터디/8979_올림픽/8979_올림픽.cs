using System;
using static System.Console;

namespace study
{
    class PlusCycle

    {
        static void Main(string[] args)
        {
            int[,] Country = new int[1001,3];
            int Grade = 1;
            int[] Silver = new int[1001];
            int SilverCount = 0;
            int[] Bronze = new int[100];
            int BronzeCount = 0;
            string Input = ReadLine();
            string[] tmpInput = Input.Split(' ');
            int SameCount = 0;

            int N = int.Parse(tmpInput[0]);
            int K = int.Parse(tmpInput[1]);

            for (int i = 1; i <= N; i++)
            {
                Input = ReadLine();
                tmpInput = Input.Split(' ');
                Country[int.Parse(tmpInput[0]), 0] = int.Parse(tmpInput[1]);
                Country[int.Parse(tmpInput[0]), 1] = int.Parse(tmpInput[2]);
                Country[int.Parse(tmpInput[0]), 2] = int.Parse(tmpInput[3]);
            }

            for (int i = 1; i <= N; i++)
            {
                if (Country[i, 0] > Country[K, 0] && i != K)
                    Grade++;

                else if (Country[i, 0] == Country[K, 0] && i != K)
                {
                    Silver[SilverCount] = i;
                    SilverCount++;
                }
            }

            for (int i = 0; i < SilverCount; i++)
            {
                if (Country[Silver[i], 1] > Country[K, 1])
                    Grade++;

                else if (Country[Silver[i], 1] == Country[K, 1])
                {
                    Bronze[BronzeCount] = Silver[i];
                    BronzeCount++;
                }
            }

            for (int i = 0; i < BronzeCount; i++)
            {
                if (Country[Bronze[i], 2] > Country[K, 2])
                    Grade++;
            }

            WriteLine(Grade);
        }
    }
}