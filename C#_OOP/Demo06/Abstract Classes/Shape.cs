using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Abstract_Classes
{
    internal abstract class Shape
    {
        // protected to be accessed through children and class only , not outside !!
        protected Shape(string color)
        {
            Color = color;
        }

        public string Color { get; set; }

        public abstract double Area();
        public abstract double Perimeter();

        public void Display()
        {
            Console.WriteLine($"Color {Color}");
        }



    }
}
