using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.GenericInterfaces
{
    // still problem of repeatition of code !!
    internal class RepoProduct : IRepository<Product, int>
    {
        List<Product> _products = new List<Product>();
        public void Add(Product item)
        {
            _products.Add(item);
        }

        public void Delete(Product item)
        {
            _products.Remove(item);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
