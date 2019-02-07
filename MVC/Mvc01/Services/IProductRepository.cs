using System.Collections.Generic;
using Mvc01.Models;

namespace Mvc01.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}