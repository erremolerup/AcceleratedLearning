using Microsoft.AspNetCore.Mvc;

namespace Mvc01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
