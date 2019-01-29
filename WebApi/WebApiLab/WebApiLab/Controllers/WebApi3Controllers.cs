using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi3")]
    public class WebApi3Controllers : Controller
    {
        [HttpGet("GetBrekkie")]
        public IActionResult GetBrekkie(string food)
        {
            if (string.IsNullOrWhiteSpace(food))
            {
                return Ok("Du måste skriva in din frukost!");
            }

            food = food.Trim();

            if (food.ToLower() == "mango")
            {
                return Ok("Mango är gott!");
            }

            return Ok(CapitalizeFirstLetter(food) + " är äckligt!");

        }

        private string CapitalizeFirstLetter(string food)
        {
            return food[0].ToString().ToUpper() + food.Substring(1).ToLower();
        }

        [HttpGet("SquaredNumber")]
        public IActionResult SquaredNumber(int number)
        {
            int numberSquared = number * number;
            string squaredResult = $"{number} * {number} = {numberSquared}";
            return Ok(squaredResult);
        }

        [HttpGet("NumberList")]
        public IActionResult NumberList(int from, int to)
        {
            var numbers = new List<int>();

            for (int i = from; i <= to; i++)
            {
                numbers.Add(i);
            }

            string numberString = string.Join(',', numbers);
            return Ok(numberString);
        }

        [HttpGet("SetBackground")]
        public IActionResult SetBackground(string color)
        {
            return Content($"<body style='background-color:{color}'></body>", "text/html");
        }
    }
}
