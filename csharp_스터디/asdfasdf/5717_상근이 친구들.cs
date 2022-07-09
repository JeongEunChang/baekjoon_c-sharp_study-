using System;
using static System.Console;

namespace study
{
    class FriendOfSangGeun
    {
        static void Main(string[] args)
        {
            int Friend = 0;

            while (true)
            {
                string Input = ReadLine();

                if (Input == "0 0")
                {
                    break;
                }

                string[] tmp = Input.Split(' ');

                Friend = int.Parse(tmp[0]) + int.Parse(tmp[1]);

                WriteLine(Friend);
            }
        }
    }
}