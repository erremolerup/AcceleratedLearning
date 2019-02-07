using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using CandyMVC.Models;
using CandyMVC.Services;
using CandyMVC.ViewModels;


namespace CandyMVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repo;

        public ProductController(ProductRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Testy()
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
            IEnumerable<ProductAttributes> allProducts = _repo.GetAll();
            return View(allProducts);
        }

        public IActionResult GetById(int id)
        {
            ProductAttributes x = _repo.GetById(id);
            return View(x);
        }

        [HttpPost]
        public IActionResult Index(ProductAttributes product)
        {
            _repo.Add(product);

            return View("AddProduct", product);
        }
    }
}
