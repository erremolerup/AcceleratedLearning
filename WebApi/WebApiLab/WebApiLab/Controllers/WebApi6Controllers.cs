using Microsoft.AspNetCore.Mvc;
using WebApiLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLab.Controllers
{
    [Route("webapi6")]
    public class WebApi6Controllers : Controller
    {
        [HttpPost("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            if (document.HasSummary == true)
            {
                var result = document.HasSummary;
            }
            return Ok($"Titel: {document.Title} \n Publicerad: {document.PublishedFrom} \n Antal sidor: {document.NumberOfPages} \n Sammanfattning: {document.HasSummary} \n Pris: {document.Price} \n Typ: {document.Type} \n Tagg: {document.TagList} \n Rating: {document.Rating}");
           
        }
    }
}
