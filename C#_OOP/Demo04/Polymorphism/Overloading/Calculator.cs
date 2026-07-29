using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Polymorphism.Overloading
{
    internal static class Calculator
    {
        // var is not allowed as value is not determined in compile time just in run time , so var not accepted
        public static int Add(int x, int y) => x + y;
        public static int Add(int x, int y, int z) => x + y + z;
        public static double Add(double x, double y) => x + y;
        public static double Add(double x, int y) => x + y;
        public static double Add(int x, double y) => x + y;
        //public int Add(int A, int B) => A + B;
    }
}
