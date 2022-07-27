using System;
using static System.Console;

namespace study
{
    class NumberOfLinked

    {
        static int N;
        static int M;
        static int Result;
        static int[,] Connection = new int[1001, 5001];
        static bool[] Visited = new bool[1001];

        static void FindResult(int Node)
        {
            if (Visited[Node] == true)
                return;

            
            Visited[Node] = true;

            for (int i = 0; i < N; i++)
            {
                if (Connection[Node, i] == 0)
                    return;

                int NextNode = Connection[Node, i];

                FindResult(NextNode);
            }
        }

        static void Main(string[] args)
        {
            string InputNode = ReadLine();
            string[] BreakInputNode = InputNode.Split(' ');

            N = int.Parse(BreakInputNode[0]);
            M = int.Parse(BreakInputNode[1]);

            for (int i = 1; i <= M; i++)
            {
                string InputLine = ReadLine();
                string[] BreakInputLine = InputLine.Split(' ');

                int Node = int.Parse(BreakInputLine[0]);
                int Connect = int.Parse(BreakInputLine [1]);
                int Index = 0;

                while (true)
                {
                    if (Connection[Node, Index] != 0)
                    {
                        Index++;
                        continue;
                    }

                    else
                    {
                        Connection[Node, Index] = Connect;
                        break;
                    }
                }

                Index = 0;

                while (true)
                {
                    if (Connection[Connect, Index] != 0)
                    {
                        Index++;
                        continue;
                    }

                    else
                    {
                        Connection[Connect, Index] = Node;
                        break;
                    }
                }
            }

            for (int i = 1; i <= N; i++)
            {
                if (Visited[i] == true)
                    continue ;

                Result++;
                FindResult(i);
            }

            WriteLine(Result);
        }
    }
}