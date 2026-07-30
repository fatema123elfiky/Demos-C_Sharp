using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Simple_interfaces
{
    internal class Circle : IShape
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double perimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
