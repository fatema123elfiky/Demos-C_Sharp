using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06.Abstract_Classes
{
    // concerte class : concerte class  -> inheritance
    // concerte class : Interface -> implementation
    // concerte class : abstract class -> implementation & inheritance
    // struct : class -> error "no inheritance supported"
    // struct : struct -> error "no inheritance supported"
    // struct : interface -> implementation


    // here is implmenting abstract methods and inheriting what is inherited 
    // abstraction should have meaning when many classes implment it not only one 
    internal class Circle : Shape
    {
        public Circle(double radius, string color= "blue") : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * Radius;
        }
    }
}
