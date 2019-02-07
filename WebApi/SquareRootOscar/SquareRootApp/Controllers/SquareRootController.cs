// Syfte: Visa hur frontend och backend hänger ihop. Hur man hanterar olika svar från servern och uppdaterar GUI't

using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootApp.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet("api/squareroot")]
        public IActionResult SquareRoot(int? number)
        {
            if (number == null)
                return BadRequest("Enter a number");

            if (number < 0)
                return BadRequest("Can't square root negative numbers");

            return Ok(Math.Sqrt((int)number));
        }

        // Alternativ för att det ska bli mer konsekvent och slippa använda "response.text" i javascript'en
        [HttpGet("api/squareroot-alternative")]
        public IActionResult SquareRoot_Alternative(int? number)
        {
            if (number == null)
                return BadRequest(new { ErrorMessage = "Enter a number" });

            if (number < 0)
                return BadRequest(new { ErrorMessage = "Can't square root negative numbers" });

            return Ok(Math.Sqrt((int)number));
        }
    }
}
