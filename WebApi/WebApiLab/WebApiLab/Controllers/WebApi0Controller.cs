using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi0")]
    public class WebApi0Controller : Controller
    {
        [Route("kalle")]
        public string Kalle()
        {
            return "Hej från Servern!";
        }

        [Route("kalle2")]
        public string Kalle2()
        {
            return "Klockan är" + System.DateTime.Now;
        }

        [Route("kalle3")]
        public int Kalle3()
        {
            int i = 10 + 32;
            return i;
        }

        //[Route("kalle4"), HttpPost]
        [HttpPost("kalle4")]
        public IActionResult Kalle4()
        {
            return Ok(666);
            //returnerar det i parentesen om allt är ok, där kan man även lägga in tex "klockan är" som ovan
        }

    }
    
}
