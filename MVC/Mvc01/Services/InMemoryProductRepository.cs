using System.Collections.Generic;
using System.Linq;
using Mvc01.Models;

namespace Mvc01.Services
{
    public class InMemoryProductRepository : IProductRepository
    {
        static List<Product> _products = new List<Product>();
        static int _lastId = 0;

        public void Add(Product product)
        {
            product.Id = _lastId;
            _products.Add(product);
            _lastId++;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.Single(x => x.Id == id);
        }
    }
}
