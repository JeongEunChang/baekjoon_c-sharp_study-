using System;
using static System.Console;

namespace study
{
    class BaseBall
    {
        static void Main(string[] args)
        {
            int GameInput;
            int Yonsei = 0;
            int Korea= 0;

            GameInput= int.Parse(ReadLine());

            for (int i = 0; i < GameInput; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string Input = ReadLine();
                    string[] tmp = Input.Split(' ');
                    int Y = int.Parse(tmp[0]);
                    int K = int.Parse(tmp[1]);

                    Korea += K;
                    Yonsei += Y;
                }

                if (Yonsei > Korea)
                    WriteLine("Yonsei");

                else if (Korea > Yonsei)
                    WriteLine("Korea");

                else if (Korea == Yonsei)
                    WriteLine("Draw");
            }
        }
    }
}