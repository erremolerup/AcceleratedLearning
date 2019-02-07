using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaDagarApp.Models;

namespace TemaDagarApp.Controllers
{   
    [Route("temadagar1")]
    public class TemaDagarController : Controller
    {
        [HttpGet("GetThemeDay")]
        public IActionResult GetThemeDay(TemaDag temaDag)
        {
            if (temaDag.TodaysDate.Day == 1 && temaDag.TodaysDate.Month == 2)
            {
                return Ok("Den 1 februari är det Vegetariska dagen! Ät mer grönt!");
            }
            if (temaDag.TodaysDate.Day == 2 && temaDag.TodaysDate.Month == 2)
            {
                return Ok("Den 2 februari är det löpningens dag! SPRING!!");
            }
            if (temaDag.TodaysDate.Day == 4 && temaDag.TodaysDate.Month == 2)
            {
                return Ok("Den 4 februari är det Vargens dag! Grrrrr");
            }
            else
            {
                return Ok("Nää sorry, det finns inget tema den här dagen.. Ät en chokladboll!");
            }
        }
    }

}
