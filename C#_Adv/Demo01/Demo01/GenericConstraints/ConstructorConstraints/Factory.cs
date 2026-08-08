using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericConstraints.ConstructorConstraints
{
    internal class Factory<T> where T : class,ICloneable,IComparable<T>,new()
    {
        public T Create ()
        {
            return new T();
        }
    }
}
