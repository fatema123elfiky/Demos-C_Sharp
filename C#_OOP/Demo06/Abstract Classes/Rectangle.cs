using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Abstract_Classes
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height,string color = "blue") : base(color)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        
        public override double Area()
        {
            return Width*Height;
        }

        public override double Perimeter()
        {
            return 2* (Width+Height);
        }
    }
}
