using System;
using static System.Console;

namespace study
{
    class ThreeNumber
    {
        static float sum = 0;

        static void Main(string[] args)
        {
            string _input = ReadLine();
            string[] input = _input.Split(' ');

            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = tmp;
                    }
                }
            }

            WriteLine(arr[1]);
        }
    }
}