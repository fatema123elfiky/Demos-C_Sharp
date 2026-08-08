using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericInterfaces
{
    internal interface IRepository <T,TKey>
    {
        public void Add (T item);

        public void Update (T item);

        public void Delete(T item);

        public T GetById(TKey id);

        public List<T> GetAll();
        
    }
}
