using System;
using static System.Console;

namespace LinkedList
{
    class Program

    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            

            list.Add(1);
            list.Add(2);
            list.Add(3);
            
            list.Remove(3);
            if (list.Find(3))
            {
                WriteLine("good");
            }
            if (list.Find(2))
            {
                WriteLine("good");
            }
            WriteLine(list.pop());
            WriteLine(list.pop());
            WriteLine(list.pop());

            if (list.Find(5))
            {
                WriteLine("good");  
            }
            //WriteLine(list.pop());
            //WriteLine(da.GetCapacity());
        }
    }
}