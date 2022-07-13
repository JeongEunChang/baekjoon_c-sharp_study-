using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Calculator<T> where T : struct
    {
        public T Sum<T>(T a, T b, OP op)
        {
            dynamic da = a, db = b;

            switch (op)
            {
                case OP.Add: return da + db;
                case OP.Sub: return da - db;
                case OP.Mul: return da * db;
                case OP.Div: return da / db;
                default: return default(T);
            }
        }

        public enum OP
        {
            Add,
            Sub,
            Mul,
            Div
        }

    }
}
