using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebApiLab.Controllers
{
    [Route("webapi4")]
    public class WebApi4Controllers : Controller
    {
        [HttpGet("DivideChocolate")]
        public IActionResult DivideChocolate(int persons)
        {
            if (persons <= 0)
            {
                
                return BadRequest($"För få personer: {persons}");
            }
            decimal pieces = 25.0M / persons;
            return Ok($"Varje person får {pieces} bitar var");
        }

        [HttpGet("LookUpOrder")]
        public IActionResult LookUpOrder(string orderId)
        {
            Match match = Regex.Match(orderId, @"^([A-Z][A-Z])-(\d{4})$", RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                return BadRequest("Fel format");
            }

            string letterPart = match.Groups[1].Value;
            int numberPart = int.Parse(match.Groups[2].Value);

            if (numberPart > 3000)
            {
                return NotFound($"Ordern {orderId} hittades inte");
            }

            return Ok($"Ordern {orderId} hittades i databasen");
        }

        [HttpGet("GetUserName")]
        public IActionResult GetUserName(string userName)
        {
            if (userName == "Stewie")
            {
                throw new Exception("DATA ERROR!!");
            }
            if (userName == "Peter")
            {
                return Content("<img src='/images/nuc.jpg' />", "text/html");
            }
            string[] okUserNames = { "Lois", "Meg", "Chris", "Brian"};
            if (okUserNames.Contains(userName))
            {
                return Content("<img src='/Controllers/thumbsup.jpg' />", "text/html");
            }
            else
            {
                return Content("<img src='/Controllers/thumbsdown.jpg' />", "text/html");
            }
        }
    }
}
