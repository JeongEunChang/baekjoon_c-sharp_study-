using System;
using static System.Console;

namespace study
{
    class Cookie
    {
        static void Main(string[] args)
        {
            string input = ReadLine();
            string[] num = input.Split(' ');

            int N = int.Parse(num[0]); // 과자 한 개 가격
            int M = int.Parse(num[1]); // 사려고 하는 과자 개수
            int K = int.Parse(num[2]); // 현재 가진 돈
            int DemandMoney = 0;

            DemandMoney = (N * M) - K;

            if (DemandMoney <= 0)
                DemandMoney = 0;
            
            WriteLine(DemandMoney);
        }
    }
}