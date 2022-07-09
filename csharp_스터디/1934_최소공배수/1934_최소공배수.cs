using System;
using static System.Console;

namespace study
{
    class LeastCommonMultiple
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = ReadLine();
                string[] arr = input.Split(" ");
                int A = int.Parse(arr[0]);
                int B = int.Parse(arr[1]);
                int Count = 1;
                int Result = 0;

                if (A < B)
                {
                    int tmp = A;
                    A = B;
                    B = tmp;
                }

                while (true)
                {
                    Result = A * Count;

                    if ((A * Count) % B == 0)
                    {
                        break;
                    }

                    Count++;
                }

                WriteLine(Result);
            } 
        }
    }
}