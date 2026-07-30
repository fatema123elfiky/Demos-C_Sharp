using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05.Simple_interfaces
{
    internal class Rectangle : IShape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
