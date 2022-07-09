using System;
using static System.Console;

namespace study
{
    class MultipleAndFactor

    {
        static void Main(string[] args)
        {
            DynamicArray da = new DynamicArray();
            da.Add(5);
            da.Add(6);
            da.Add(7);
            da.Add(7);
            da.Add(7);
            //DArr.Remove(6);
            //DArr.Remove(10);
            //DArr.Clear();

            for (int i = 0; i < da.GetLength(); i++)
            {
                WriteLine(da.Array[i]);
            }

            WriteLine(da.GetLength());
            WriteLine(da.GetCapacity());
        }
    }
}