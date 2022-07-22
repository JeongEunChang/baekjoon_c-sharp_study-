using System;
using static System.Console;

namespace study
{
    class Digital_TV

    {
        static void Main(string[] args)
        {
            string Input1 = ReadLine();
            int ChannelNum = int.Parse(Input1);
            string[] ChannelArr = new string[ChannelNum];

            for (int i = 0; i < ChannelNum; i++)
            {
                string Input2 = ReadLine();
                ChannelArr[i] = Input2;
            }

            for (int i = 0; i < ChannelNum; i++)
            {
                if (ChannelArr[i] == "KBS1")
                {
                    for (int j = i; j > 0; j--)
                    {
                        string tmp = ChannelArr[j];
                        ChannelArr[j] = ChannelArr[j - 1];
                        ChannelArr[j - 1] = tmp;
                        Write('4');
                    }

                    break;
                }

                Write('1');
            }

            if (ChannelArr[1] == "KBS2")
            {
                return;
            }

            for (int i = 0; i < ChannelNum; i++)
            {
                if (ChannelArr[i] == "KBS2")
                {
                    for (int j = i; j > 1; j--)
                    {
                        Write('4');
                    }

                    break;
                }

                Write('1');
            }
        }
    }
}