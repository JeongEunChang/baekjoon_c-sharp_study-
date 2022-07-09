using System;
using static System.Console;

namespace study
{
    class GradeCaculation
    {
        static void Main(string[] args)
        {
            string Input = ReadLine();
            float Grade = 0;

            if (Input[0] == 'A')
            {
                if (Input[1] == '+')
                {
                    Grade = 4.3f;
                }

                else if (Input[1] == '0')
                {
                    Grade = 4.0f;
                }

                else if (Input[1] == '-')
                {
                    Grade = 3.7f;
                }
            }

            else if (Input[0] == 'B')
            {
                if (Input[1] == '+')
                {
                    Grade = 3.3f;
                }

                else if (Input[1] == '0')
                {
                    Grade = 3.0f;
                }

                else if (Input[1] == '-')
                {
                    Grade = 2.7f;
                }
            }

            else if (Input[0] == 'C')
            {
                if (Input[1] == '+')
                {
                    Grade = 2.3f;
                }

                else if (Input[1] == '0')
                {
                    Grade = 2.0f;
                }

                else if (Input[1] == '-')
                {
                    Grade = 1.7f;
                }
            }

            else if (Input[0] == 'D')
            {
                if (Input[1] == '+')
                {
                    Grade = 1.3f;
                }

                else if (Input[1] == '0')
                {
                    Grade = 1.0f;
                }

                else if (Input[1] == '-')
                {
                    Grade = 0.7f;
                }
            }

            else if (Input[0] == 'F')
            {
                Grade = 0.0f;
            }




            WriteLine("{0:f1}", Grade);
        }
    }
}