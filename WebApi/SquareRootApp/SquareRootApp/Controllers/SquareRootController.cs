using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootApp.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet("SquareRoot")]
        public IActionResult SquareRoot(int? number)
        {
            if (number == null)
            {
                return BadRequest("Du måste ange ett nummer");
            }
            if (number < 0)
            {
                return BadRequest("Du måste ange ett positivt tal");
            }
            return Ok(Math.Sqrt((int)number));

        }
        
    }
}
