using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02.BasicDelegate
{
    //delegate int MathOperation(int a, int b);
    delegate T MathOperation<T>(T a, T b);
    internal class Calculator
    {
        public static int add(int x, int y)
        {
            return x + y;
        }

        public static decimal addDecimal(decimal x, decimal y)
        {
            return x + y;
        }
        public static int subtract(int x, int y)
        {
            return x - y;
        }
    }
}
