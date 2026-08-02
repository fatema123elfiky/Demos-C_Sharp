using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Extensions
{
    internal static class Helper
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number) { return number % 2 == 1; }
    }
}
