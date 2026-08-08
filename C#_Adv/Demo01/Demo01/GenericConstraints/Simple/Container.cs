using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericConstraints.Simple
{
    internal class Container<T> where T : class
    {
        public Container(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

    }
}
