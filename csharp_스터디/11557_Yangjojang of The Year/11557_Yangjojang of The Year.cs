using System;
using static System.Console;
using static System.Array;

namespace study
{
    class YangjojangOfTheYear
    {
        static void Main(string[] args)
        {
            int CaseNum = int.Parse(ReadLine());

            for (int i = 0; i < CaseNum; i++)
            {
                int SchoolNum = int.Parse(ReadLine());
                string[] SchoolArr = new string[100];
                int[] AlcoholArr = new int[100];
                int big = 0;
                int bigIndex = 0;

                for (int j = 0; j < SchoolNum; j++)
                {
                    string Input = ReadLine();
                    int Null_Index = Input.IndexOf(' ');
                    char[] schooltmp = new char[Null_Index];
                    char[] alcoholtmp = new char[Input.Length - Null_Index - 1];
                    
                    for (int k = 0; k < Null_Index; k++)
                    {
                        schooltmp[k] = Input[k];
                    }

                    for (int l = 0; l < Input.Length - Null_Index - 1; l++)
                    {
                        alcoholtmp[l] = Input[l + Null_Index + 1];
                    }

                    int tmp = Null_Index + 1;
                    SchoolArr[j] = Input[0..Null_Index]; //Convert.ToString(schooltmp);

                    AlcoholArr[j] = int.Parse(Input[tmp..^0]); //int.Parse(alcoholtmp.ToString());
                }

                for (int k = 0; k < AlcoholArr.Length; k++)
                {
                    if (AlcoholArr[k] > big)
                    {
                        big = AlcoholArr[k];
                        bigIndex = k;
                    }

                }

                WriteLine(SchoolArr[bigIndex]);
            }
        }
    }
}