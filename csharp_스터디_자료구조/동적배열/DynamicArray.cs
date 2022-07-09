using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Array;

namespace study
{
    public class DynamicArray
    {
        int Index = 0;
        int Capacity = 1;
        public int[] Array = new int[1];

        public bool Add(int data)
        {
            if (Capacity <= Index)
            {
                Capacity = Capacity * 2;
                int[] tmp = new int[Capacity];

                for (int i = 0; i < Index; i++)
                    tmp[i] = Array[i];

                Array = tmp;
            }

                Array[Index] = data;
                Index++;

            return true;
        }

        public int GetLength()
        {
            return Index;
        }

        public int GetCapacity()
        {
            return Capacity;
        }
        public bool Remove(int data)
        {
            if (Array.Contains(data))
            {
                int DataIndex = IndexOf(Array, data);

                for (int i = DataIndex; i < Index; i++)
                {
                    Array[i] = Array[i + 1];
                }

                Index--;

                return true;
            }
            
            return false;
        }

        public bool Clear()
        {
            Array = new int[Capacity];
            Index = 0;

            return true;
        }
    }
}
