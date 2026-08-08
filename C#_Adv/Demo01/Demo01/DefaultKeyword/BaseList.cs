using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.DefaultKeyword
{
    internal class BaseList<T>
    {
        private List<T> _base = new List<T>( ) ;

        public void Add(T item)
        {
           if(_base is not null) 
                _base.Add(item);
        }

        public T GetValue(int index)
        {
            if (_base is not null && index >= 0 && index < _base.Count)
                return _base[index];
           return default(T);
        }
    }
}
