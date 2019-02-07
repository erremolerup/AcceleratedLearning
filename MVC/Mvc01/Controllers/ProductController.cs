using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Mvc01.Models;
using Mvc01.Services;
using Mvc01.ViewModels;

namespace Mvc01.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Testy()
        {
            return View();
        }

        public IActionResult Yrittää()
        {
            return View();
        }

        public IActionResult Index()
        {
            var vm = new ProductListVm
            {
                AllProducts = _repo.GetAll().Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                })
            };

            return View(vm);
        }


        public IActionResult ListAll()
        {
            IEnumerable<Product> allProducts = _repo.GetAll();
            return View(allProducts);
        }

        public IActionResult GetById(int id)
        {
            Product x = _repo.GetById(id);
            return View(x);
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            _repo.Add(product);

            return View("ProductAdded", product);
        }
    }
}
