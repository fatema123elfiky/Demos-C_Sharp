using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Overriding
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public new void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }

        public override double Area()=>Radius * Radius * Math.PI;
        
    }
}
