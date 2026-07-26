using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Static
{
    internal static class Counter
    {
        static int counter =0;

        // static method just access static vars no way to access normal vars 
        public static void Increment() => counter++;
        public static void Decrement() => counter--;
        public static void Reset() => counter=0;
        public static int Get() => counter;

        

    }
}
