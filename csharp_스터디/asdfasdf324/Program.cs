using System;
using static System.Console;

namespace study
{
    class BiggerNumber_A_Plus_B
    {
        static void Main(string[] args)
        {
            string Input = ReadLine();
            string[] tmpInput = Input.Split(' ');
            char[] A; //= new char[tmpInput[0].Length];
            char[] B; //= new char[tmpInput[1].Length];
            A = tmpInput[0].ToCharArray();
            B = tmpInput[1].ToCharArray();
            //string A = tmpInput[0];
            //string B = tmpInput[1];

            if (A.Length > B.Length)
            {
                int tmpA;
                int tmpB;
                int Gap = A.Length - B.Length; ;

                for (int i = B.Length - 1; i >= 0; i--)
                {
                    tmpA = A[i + Gap] - 48;
                    tmpB = B[i] - 48;

                    if (tmpA + tmpB >= 10)
                    {
                        A[i + Gap + 1] = ((char)(A[i + Gap] + 1));
                        A[i + Gap] = (char)(tmpA + tmpB - 10 + 48);
                    }

                    else
                    {
                        A[i + Gap] = (char)(tmpA + tmpB + 48);
                    }
                }

                WriteLine(A);
            }

            else if (A.Length < B.Length)
            {
                int tmpA;
                int tmpB;
                int Gap = B.Length - A.Length; ;

                for (int i = A.Length - 1; i >= 0; i--)
                {
                    tmpA = A[i] - 48;
                    tmpB = B[i + Gap] - 48;

                    if (tmpA + tmpB >= 10)
                    {
                        B[i + Gap + 1] = ((char)(B[i + Gap] + 1));
                        B[i + Gap] = (char)(tmpA + tmpB - 10 + 48);
                    }

                    else
                    {
                        B[i + Gap] = (char)(tmpA + tmpB + 48);
                    }
                }

                WriteLine(B);
            }

            else
            {
                int tmpA;
                int tmpB;

                for (int i = A.Length - 1; i >= 0; i--)
                {
                    tmpA = A[i] - 48;
                    tmpB = B[i] - 48;

                    if (tmpA + tmpB >= 10 && i != 0)
                    {
                        A[i + 1] = ((char)(A[i] + 1));
                        A[i] = (char)(tmpA + tmpB - 10 + 48);
                    }

                    else if (tmpA + tmpB >= 10 && i == 0)
                    {
                        A[i] = (char)(tmpA + tmpB - 10 + 48);
                        Write("1");
                    }

                    else
                    {
                        A[i] = (char)(tmpA + tmpB + 48);
                    }
                }

                WriteLine(A);
            }
        }
    }
}