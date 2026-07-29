using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04.Overriding
{
    internal class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle !");
        }

        public virtual double Area()
        {
            return 0;
        } 
    }
}
