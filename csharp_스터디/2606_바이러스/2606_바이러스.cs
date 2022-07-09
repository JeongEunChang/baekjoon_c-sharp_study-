using System;
using static System.Console;

namespace study // 기존 완전 탐색이 틀렸떤 이유는, 입력 받는 순서에 따라서 인덱스 1부터 차례대로 감염시기키 때문에 순서에 따라
{// 감염이 진행이 안될 수도 있었음. 몇 번을 반복시키더라도. ex) 78 89 91
    class Virus
    {
        class Computer
        {
            public string name;
            public bool infection;
            public int[] LinkedComputer = new int[5000];
            public int index;
        }

        static void Inspection(Computer[] AllComputer, int ComputerNumber)
        {
            for (int i = 0; i < AllComputer[ComputerNumber].index; i++)
            {
                int tmp = AllComputer[ComputerNumber].LinkedComputer[i];

                if (AllComputer[tmp].infection != true)
                {
                    AllComputer[tmp].infection = true;
                    Inspection(AllComputer, tmp);
                }
            }
        }

        static void Main(string[] args)
        {
            int ComputerInput = int.Parse(ReadLine());
            int LinkInput = int.Parse(ReadLine());
            int InpectionCount = 0;
            Computer[] AllComputer = new Computer[ComputerInput + 1];

            for (int i = 1; i <= ComputerInput; i++)
            {
                AllComputer[i] = new Computer();
                AllComputer[i].name = i.ToString();
                AllComputer[(int)i].infection = false;
                AllComputer[(int)i].index = 0;
            }

            for (int i = 0; i < LinkInput; i++)
            {
                string Input = ReadLine();
                string[] Link = Input.Split(' ');
                int a = int.Parse(Link[0]);
                int b = int.Parse(Link[1]);

                AllComputer[a].LinkedComputer[AllComputer[a].index] = b;
                AllComputer[a].index = AllComputer[a].index + 1;
                AllComputer[b].LinkedComputer[AllComputer[b].index] = a;
                AllComputer[b].index = AllComputer[b].index + 1;
            }

            AllComputer[1].infection = true;

            Inspection(AllComputer, 1);

            for ( int i = 1; i <= ComputerInput; i++)
            {
                if (AllComputer[i].infection == true)
                    InpectionCount++;
            }

            WriteLine(InpectionCount - 1);
        }
    }
}