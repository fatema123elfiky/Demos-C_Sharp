using Common07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Extensions
{
    internal static class ProductExtensions
    {
        public static void Print (this Product product)
        {
            Console.WriteLine ("product");
        }

    }
}
