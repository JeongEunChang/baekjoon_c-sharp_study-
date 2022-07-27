using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {

        public class Node
        {
            public Node Next;
            public Node Pre;
            public int Value;
        }

        public Node Head;
        public Node Tail;
        int mLength;

        public LinkedList()
        {
            //Head = null;
            //Tail = null;
            mLength = 0;
        }

        public bool Add(int Value)
        {
            Node tmp = new Node();

            if (Head == null)
            {
                Head = tmp;
                Head.Pre = null;
                Head.Next = null;
                Head.Value = Value;
                mLength++;
                return true;
            }

            if (Tail == null)
            {
                Tail = tmp;
                Tail.Pre = Head;
                Head.Next = tmp;
                Tail.Next = null;
                Tail.Value = Value;
                mLength++;
                return true;
            }

            tmp.Pre = Tail;
            tmp.Next = null;
            tmp.Value = Value;
            Tail.Next = tmp;
            Tail = tmp;
            mLength++;

            return true;
        }

        public bool Remove(int Value)
        {
            if (Find(Value))
            {
                Node Now = Head;

                while (true)
                {
                    if (Now.Value == Value)
                    {
                        if (Now == Head)
                        {
                            Tail = null;
                            return true;
                        }

                        if (Now == Tail)
                        {
                            Now.Pre.Next = null;
                            Tail = Now.Pre;
                            return true;
                        }

                        Now.Pre.Next = Now.Next;
                        Now.Next.Pre = Now.Pre;

                        return true;
                    }

                    if (Now == Tail)
                    {
                        return false;
                    }

                    Now = Now.Next;
                }

                return false;
            }

            return false;
        }

        //public bool Clear()
        //{

        //}

        public int pop()
        {
            int ReturnValue;

            if (Tail == null)
            {
                if (Head == null)
                {
                    return -1;
                }

                ReturnValue = Head.Value;
                Head = null;

                return ReturnValue;
            }

            ReturnValue = Tail.Value;

            if (Tail.Pre == Head)
            {
                Tail.Pre.Next = null;
                Tail = null;
                return ReturnValue;

            }

            Tail.Pre.Next = null;
            Tail = Tail.Pre;

            return ReturnValue;
        }

        public bool Find(int Value)
        {
            if (Head == null)
            {
                return false;
            }

            Node Now = Head;

            while (true)
            {
                if (Now.Value == Value)
                {
                    return true;
                }

                if (Now == Tail || Tail == null)
                {
                    return false;
                }

                Now = Now.Next;
            }
        }

        public int Length()
        {
            return mLength;
        }

    }
}
