using System;
using static System.Console;

namespace study
{
    class Noise
    {
        static void Main(string[] args)
        {
            string A = ReadLine();
            string op = ReadLine();
            string B = ReadLine();

            if (op == "*")
            {
                int a = A.Length - 1; // 1 을 제외한 0 부분만 추출
                int b = B.Length - 1; // 1 을 제외한 0 부분만 추출
                int len = a + b; // a 와 b 를 곱했을 때 생기는 0 개수

                Write("1"); // 1 출력, 띄어쓰기 x
                for (int i = 0; i < len; i++)
                {
                    Write("0"); // a 와 b 를 곱했을 때 생기는 0의 개수 만큼 0 을 출력, 띄어쓰기 x
                }
            }

            else if (op == "+")
            {
                string tmp;

                if (B.Length > A.Length)
                {
                    tmp = B;
                    B = A;
                    A = tmp;

                    Write("1");
                    for (int i = 1; i < A.Length - 1; i++)
                    {
                        if (i == (A.Length - B.Length))
                        {

                            Write("1");
                        }

                        Write("0");
                    }
                    if (B == "1")
                        Write("1");

                }
            
                
                else if (B.Length == A.Length)
                {
                    Write("2");
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        Write("0");
                    }
                }

                else if (B.Length < A.Length)
                {
                    Write("1");
                    for (int i = 1; i < A.Length - 1; i++)
                    {
                        if (i == (A.Length - B.Length))
                        { 

                            Write("1");
                        }

                            Write("0");
                    }
                    if (B == "1")
                        Write("1");
                }
            }
        }
    }
}