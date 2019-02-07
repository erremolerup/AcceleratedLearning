using System.Collections.Generic;
using CandyMVC.Models;

namespace CandyMVC
{
    internal interface IProductRepository
    {
        IEnumerable<ProductAttributes> GetAll();
        ProductAttributes GetById(int id);
        void Add(ProductAttributes product);
    }
}