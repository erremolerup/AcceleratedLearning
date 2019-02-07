using Microsoft.AspNetCore.Mvc;

namespace CandyMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
