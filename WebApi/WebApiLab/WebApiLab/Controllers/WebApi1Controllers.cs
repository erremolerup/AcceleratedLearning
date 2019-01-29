using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi1")]
    public class WebApi1Controllers : Controller
    {

        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            // Du behöver göra "Planet"-klassen och metoden "ParsePlanet"
            Planet planet = ParsePlanet(formContent);

            return Ok($"Ny planet {planet.PlanetName} skapad med storleken {planet.PlanetSize}");
        }

        [HttpGet("GetPlanet")]
        public IActionResult GetPlanet()
        {
            string formContent = Request.QueryString.Value.TrimStart('?');

            Planet planet = ParsePlanet(formContent);

            return Ok($"Söker i databasen efter planeter med namn {planet.PlanetName} och storleken {planet.PlanetSize}");
        }

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok($"Ny planet {planet.PlanetName} skapad med storleken {planet.PlanetSize}");
        }

        [HttpGet("GetPlanet2")]
        public IActionResult GetPlanet2(Planet planet)
        {
            return Ok($"Söker i databasen efter planeter med namn {planet.PlanetName} och storleken {planet.PlanetSize}");
        }

        private Planet ParsePlanet(string formContent)
        {

            string[] splitPlanet = formContent.Split('&');

            string planetName = splitPlanet[0].Split('=')[1];
            int planetSize = int.Parse(splitPlanet[1].Split('=')[1]);

            Planet planet1 = new Planet
            {
                PlanetName = planetName,
                PlanetSize = planetSize
            };

            return planet1;
        }
    }
}
