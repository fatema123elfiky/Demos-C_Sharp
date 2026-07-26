using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Inheritance
{
    internal class BadCar:Engine
    {
        public string Model { get; set; }
        public BadCar(string model , string type , int num) : base(type,num)
        {
            Model = model;
        }
    }
}
