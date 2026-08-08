using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Box<T>
    {
        public T Value {  get; set; }
        public Box(T value)
        {
            Value = value;
        }
    }
}
