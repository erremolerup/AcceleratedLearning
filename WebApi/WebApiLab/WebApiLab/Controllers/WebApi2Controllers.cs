using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi2")]
    public class WebApi2Controllers : Controller
    {
        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hello";
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello World");

        }

        [HttpGet("TodaysDate")]
        public DateTime TodaysDate()
        {
            DateTime today = DateTime.Today;
            return today;
        }

        [HttpGet("TodaysCliche")]
        public string TodaysCliche()
        {
            DayOfWeek thisDay = GetWeekDay();

            if (thisDay == DayOfWeek.Monday)
            {
                return "All that glitters isn't gold";
            }
            if (thisDay == DayOfWeek.Tuesday)
            {
                return "Don't get your knickers in a twist";
            }
            if (thisDay == DayOfWeek.Wednesday)
            {
                return "All for one, and one for all";
            }
            if (thisDay == DayOfWeek.Thursday)
            {
                return "Read between the lines";
            }
            if (thisDay == DayOfWeek.Friday)
            {
                return "Time flies";
            }
            if (thisDay == DayOfWeek.Saturday)
            {
                return "Fit as a fiddle";
            }
            if (thisDay == DayOfWeek.Sunday)
            {
                return "Don't cry over spilled milk";
            }
            return null;
            
        }

        private DayOfWeek GetWeekDay()
        {
            DateTime today = DateTime.Today;
            var thisDay = DateTime.Today.DayOfWeek;
            
            return thisDay;
        }
    }
}
