using System;
using static System.Console;

namespace study
{
    class OXQuiz
    {
        static void Main(string[] args)
        {
            int GameInput;

            GameInput = int.Parse(ReadLine());

            for (int i = 0; i < GameInput; i++)
            {
                string Input = ReadLine();
                int Score = 0;
                int O_Count = 1;

                for (int j = 0; j < Input.Length; j++)
                {
                    if (Input[j] == 'O')
                    {
                        Score += O_Count;
                        O_Count++;
                    }

                    else if (Input[j] == 'X')
                    {
                        O_Count = 1;
                    }
                }

                WriteLine(Score);
            }
        }
    }
}