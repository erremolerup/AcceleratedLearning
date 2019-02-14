using CandyMVC.Models;
using CandyMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMVC.Controllers
{
    public class WeatherController : Controller
    {
        private SmhiService _service;

        public WeatherController(SmhiService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPrognosis()
        {
            IEnumerable<ProductAttributes> allProducts = _service.GetAll();
            return View(allProducts);
        }
    }
}
