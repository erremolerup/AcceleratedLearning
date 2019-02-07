using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CandyMVC.Models;


namespace CandyMVC.Services
{
    public class ProductRepository : IProductRepository
    {
        private IHostingEnvironment _env;

        public ProductRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<ProductAttributes> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = GetFilenameForProductList();
            IEnumerable<ProductAttributes> allProducts = File.ReadAllLines(filename).Select(x => new ProductAttributes
            {
                Id = int.Parse(x.Split(",")[0]),
                Name = x.Split(",")[1],
                Description = x.Split(",")[2]
            }); ;

            return allProducts;
        }

        public ProductAttributes GetById(int id)
        {
            return GetAll().Single(x => x.Id == id);
        }

        public void Add(ProductAttributes product)
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
