using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi5")]
    public class WebApi5Controllers : Controller
    {
        [HttpGet("AddPerson")]
        public IActionResult AddPerson(SimplePerson simplePerson)
        {
            return Ok($"Personen {simplePerson.Name} som är {simplePerson.Age} år gammal lades precis till i databasen");
        }

        [HttpGet("ValidatePerson")]
        public IActionResult ValidatePerson(SimplePerson simplePerson)
        {
            var errors = new List<String>();

            if (simplePerson.Name?.Length > 20)
            {
                errors.Add("Ditt namn får inte ha mer än 20 tecken");
            }
            if (string.IsNullOrEmpty(simplePerson.Name))
            {
                errors.Add("Du måste ange ett namn");
            }

            if (simplePerson?.Age == null)
            {
                errors.Add("Du måste ange en ålder");
            }
            if (simplePerson.Age < 0 || simplePerson.Age > 120)
            {
                return BadRequest("Din ålder måste vara mellan 0 och 120");
            }
            if (errors.Count > 0)
            {
                return BadRequest(string.Join(".", errors));
            }
            else
            {
                return Ok($"{simplePerson.Name} som är {simplePerson.Age} år har lagts till i databasen ");
            }
        }

        [HttpGet("ValidatePersonAttribute")]
        public IActionResult ValidatePersonAttribute(SimplePersonWithAttributes person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok($"{person.Name} som är {person.Age} har lagts till i databasen");
        }
    }
}

