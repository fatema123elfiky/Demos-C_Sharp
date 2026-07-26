using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Inheritance
{
    internal class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Car (string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car (string model , string type , int num)
        {
            Model = model;
            Engine = new Engine(type, num);
        }
    }
}
