using System;
using static System.Console;

namespace study
{
    class MicrowaveOven
    {
        static bool CheckFlusch = false;
        static int Biggest = 0;
        static char[] Color = new char[5];
        static int[] Value = new int[5];
        static int Three = 0;
        static int FullHouse1 = 0;
        static int FullHouse2 = 0;
        static int Two1 = 0;
        static int Two2 = 0;
        static int Four = 0;
        static int One = 0;

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                string Input = ReadLine();
                string[] tmpInput = Input.Split(' ');

                Color[i] = char.Parse(tmpInput[0]);
                Value[i] = int.Parse(tmpInput[1]);

                if (Value[i] > Biggest)
                    Biggest = Value[i];
            }

            Array.Sort(Value);

            if (Color[0] == Color[1]
                && Color[0] == Color[2]
                && Color[0] == Color[3]
                && Color[0] == Color[4])
            {
                CheckFlusch = true;
            }

            if (CheckSF())
            {
                WriteLine(900 + Biggest);
            }

            else if (CheckFC())
            {
                WriteLine(800 + Four);
            }

            else if (CheckFH())
            {
                WriteLine(700 + FullHouse2 * 10 + FullHouse1);
            }

            else if (CheckF())
            {
                WriteLine(600 + Biggest);
            }

            else if (CheckS())
            {
                WriteLine(500 + Biggest);
            }

            else if (CheckThree())
            {
                WriteLine(400 + Three);
            }

            else if (CheckTwoPair())
            {
                WriteLine(300 + Two2 * 10 + Two1);
            }

            else if (CheckOnePair())
            {
                WriteLine(200 + One);
            }

            else
            {
                WriteLine(100 + Biggest);
            }
        }


        static bool CheckSF()
        {
            if (Value[0] + 1 == Value[1]
                && Value[1] + 1 == Value[2]
                && Value[2] + 1 == Value[3]
                && Value[3] + 1 == Value[4]
                && CheckFlusch == true)
            {
                return true;
            }

            else
                return false;
        }

        static bool CheckFC()
        {
            if (Value[0] == Value[1]
                && Value[0] == Value[2]
                && Value[0] == Value[3])
            {
                Four = Value[0];
                return true;
            }

            else if (Value[1] == Value[2]
                && Value[1] == Value[3]
                && Value[1] == Value[4])
            {
                Four = Value[1];
                return true;
            }

            else
                return false;
        }

        static bool CheckFH()
        {
            if (Value[0] == Value[1]
                && Value[2] == Value[3]
                && Value[2] == Value[4])
            {
                FullHouse1 = Value[0];
                FullHouse2 = Value[2];
                return true;
            }

            else if (Value[0] == Value[1]
                && Value[0] == Value[2]
                && Value[3] == Value[4])
            {
                FullHouse1 = Value[3];
                FullHouse2 = Value[0];
                return true;
            }

            else
                return false;
        }

        static bool CheckF()
        {
            if (CheckFlusch == true)
                return true;

            else
                return false;
        }

        static bool CheckS()
        {
            if (Value[0] + 1 == Value[1]
                && Value[1] + 1 == Value[2]
                && Value[2] + 1 == Value[3]
                && Value[3] + 1 == Value[4])
            {
                return true;
            }

            else
                return false;
        }

        static bool CheckThree()
        {
            if (Value[2] == Value[1]
                && Value[2] == Value[0])
            {
                Three = Value[2];
                return true;
            }

            else if (Value[2] == Value[3]
                && Value[2] == Value[4])
            {
                Three = Value[2];
                return true;
            }

            else if (Value[1] == Value[2]
                && Value[1] == Value[3])
            {
                Three = Value[1];
                return true;
            }

            else
                return false;
        }

        static bool CheckTwoPair()
        {
            if (Value[0] == Value[1]
                & Value[2] == Value[3])
            {
                if (Value[0] > Value[2])
                {
                    Two1 = Value[2];
                    Two2 = Value[0];
                }

                else if (Value[0] < Value[2])
                {
                    Two1 = Value[0];
                    Two2 = Value[2];
                }

                return true;
            }

            else if (Value[0] == Value[1]
                && Value[3] == Value[4])
            {
                if (Value[0] > Value[3])
                {
                    Two1 = Value[3];
                    Two2 = Value[0];
                }

                else if (Value[0] < Value[3])
                {
                    Two1 = Value[0];
                    Two2 = Value[3];
                }

                return true;
            }

            else if (Value[1] == Value[2]
                && Value[3] == Value[4])
            {
                if (Value[1] > Value[3])
                {
                    Two1 = Value[3];
                    Two2 = Value[1];
                }

                else if (Value[1] < Value[3])
                {
                    Two1 = Value[1];
                    Two2 = Value[3];
                }

                return true;
            }

            else
                return false;
        }

        static bool CheckOnePair()
        {
            if (Value[0] == Value[1])
            {
                One = Value[1];
                return true;
            }

            else if (Value[1] == Value[2])
            {
                One = Value[1];
                return true;
            }

            else if (Value[2] == Value[3])
            {
                One = Value[3];
                return true;
            }

            else if (Value[3] == Value[4])
            {
                One = Value[3];
                return true;
            }

            else
                return false;
        }
    }
}