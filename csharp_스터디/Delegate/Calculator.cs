using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Calculator
    {
        delegate int IntCacul(int a, int b, OP op);
        delegate float FloatCacul(float a, float b, OP op);
        delegate double DoubleCacul(double a, double b, OP op);

        IntCacul _Int;
        FloatCacul _Float;
        DoubleCacul _Double;

        public Calculator()
        {
            _Int = new(CaculationInt);
            _Float = new(CaculationFloat);
            _Double = new(CaculationIDouble);
        }
        
        void PrintCalcul()

        int CaculationInt(int a, int b, OP op)
        {

            switch (op)
            {
                case OP.Add: return a + b;
                case OP.Sub: return a - b;
                case OP.Mul: return a * b;
                case OP.Div: return a / b;
                default: return default;
            }
        }

        float CaculationFloat(float a, float b, OP op)
        {
            switch (op)
            {
                case OP.Add: return a + b;
                case OP.Sub: return a - b;
                case OP.Mul: return a * b;
                case OP.Div: return a / b;
                default: return default;
            }
        }

        double CaculationIDouble(double a, double b, OP op)
        {
            switch (op)
            {
                case OP.Add: return a + b;
                case OP.Sub: return a - b;
                case OP.Mul: return a * b;
                case OP.Div: return a / b;
                default: return default;
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
