using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorExample
{
    public static class Calculator
    {
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Sub(float n1, float n2)
        {
            return n1 - n2;
        }
        public static float Mul(float n1, float n2)
        {
            return n1 * n2;
        }
        public static decimal Div(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}
