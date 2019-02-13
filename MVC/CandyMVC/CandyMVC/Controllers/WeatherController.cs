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
        //private SmhiService _service;

        //public WeatherController(ProductRepository service)
        //{
        //    _service = service;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
