using System;
using static System.Console;

namespace study
{
    class TGN
    {


        static void Main(string[] args)
        {
            int IputCount = int.Parse(ReadLine());

            for (int i = 0; i < IputCount; i++)
            {
                string Input = (ReadLine());
                string[] InputArr = Input.Split(' ');
                double NotAd = double.Parse(InputArr[0]);
                double Ad = double.Parse(InputArr[1]);
                double Money = double.Parse(InputArr[2]);

                if (Ad - Money > NotAd)
                {
                    WriteLine("advertise");
                }

                else if (Ad - Money == NotAd)
                {
                    WriteLine("does not matter");
                }

                else if (Ad - Money < NotAd)
                {
                    WriteLine("do not advertise");
                }
            }
        }
    }
}