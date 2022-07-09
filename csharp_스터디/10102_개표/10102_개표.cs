using System;
using static System.Console;

namespace study
{
    class BallotCount
    {
        static void Main(string[] args)
        {
            int VoteCount = int.Parse(ReadLine());
            string Vote = ReadLine();
            int A = 0;
            int B = 0;

            for (int i = 0; i < VoteCount; i++)
            {
                if (Vote[i] == 'A')
                    A++;

                else if (Vote[i] == 'B')
                    B++;
            }

            if (A > B)
                WriteLine('A');

            else if (A < B)
                WriteLine('B');

            else if (A == B)
                WriteLine("Tie");
        }
    }
}