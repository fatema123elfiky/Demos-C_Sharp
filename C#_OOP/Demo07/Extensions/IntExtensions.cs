using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Extensions
{
    internal static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number) { return number % 2 == 1; }
    }
}
