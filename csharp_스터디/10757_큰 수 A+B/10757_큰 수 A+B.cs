using System;
using static System.Console;
using System.Text;

namespace study
{
    class BiggerNumber_A_Plus_B
    {
        static void Main(string[] args)
        {
            string Input = ReadLine();
            string[] tmpInput = Input.Split(' ');
            char[] cA; //= new char[tmpInput[0].Length];
            char[] cB; //= new char[tmpInput[1].Length];
            cA = tmpInput[0].ToCharArray();
            cB = tmpInput[1].ToCharArray();
            Array.Reverse(cA);
            Array.Reverse(cB);
            string A = new string(cA);
            string B = new string(cB);
            StringBuilder Result = new StringBuilder();
            int Overed = 0;

            while ((B != String.Empty) || (A != String.Empty))
            {
                if (A == String.Empty)
                {
                    if (Overed == 1)
                    {
                        if (B[0] == '9')
                        {
                            Result.Insert(0, '0');
                            B = B.Remove(0, 1);
                            Overed = 1;
                        }

                        else
                        {
                            Result.Insert(0, (char)(B[0] + 1));
                            B = B.Remove(0, 1);
                            Overed = 0;
                        }
                    }

                    else
                    {
                        Result.Insert(0, B[0]);
                        B = B.Remove(0, 1);
                    }
                }

                else if (B == String.Empty)
                {
                    if (Overed == 1)
                    {
                        if (A[0] == '9')
                        {
                            Result.Insert(0, '0');
                            A = A.Remove(0, 1);
                            Overed = 1;
                        }

                        else
                        {
                            Result.Insert(0, (char)(A[0] + 1));
                            A = A.Remove(0, 1);
                            Overed = 0;
                        }
                    }

                    else
                    {
                        Result.Insert(0, A[0]);
                        A = A.Remove(0, 1);
                    }
                }

                else
                {
                    int tmpA = A[0] - 48;
                    int tmpB = B[0] - 48;

                    if (Overed == 1)
                    {
                        tmpA = A[0] - 48 + 1;
                        Overed = 0;
                    }

                    if (tmpA + tmpB >= 10)
                    {
                        Result.Insert(0, (char)(tmpA + tmpB - 10 + 48));
                        Overed = 1;
                        A = A.Remove(0, 1);
                        B = B.Remove(0, 1);
                    }

                    else
                    {
                        Result.Insert(0, (char)(tmpA + tmpB + 48));
                        A = A.Remove(0, 1);
                        B = B.Remove(0, 1);
                    }
                }

            }

            if (Overed == 1)
                Write(1);

            WriteLine(Result);          
        }
    }
}