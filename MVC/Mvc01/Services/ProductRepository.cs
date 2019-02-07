using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mvc01.Models;

namespace Mvc01.Services
{
    public class ProductRepository : IProductRepository
    {
        private IHostingEnvironment _env;

        public ProductRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<Product> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = GetFilenameForProductList();
            IEnumerable<Product> allProducts = File.ReadAllLines(filename).Select(x => new Product
            {
                Id = int.Parse(x.Split(",")[0]),
                Name = x.Split(",")[1],
                Description = x.Split(",")[2]
            }); ;

            return allProducts;
        }

        public Product GetById(int id)
        {
            return GetAll().Single(x => x.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = GetAll().Max(x => x.Id) + 1;
            File.AppendAllText(GetFilenameForProductList(), $"{product.Id},{product.Name},{product.Description}\n");
        }

        private string GetFilenameForProductList()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "products.txt");
            return filename;
        }
    }
}
