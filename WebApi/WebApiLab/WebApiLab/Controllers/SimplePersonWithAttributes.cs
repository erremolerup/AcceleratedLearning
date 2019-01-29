using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApiLab.Controllers
{
    public class SimplePersonWithAttributes
    {
        [Display(Name = "Förnamn")]
        [Required(ErrorMessage ="Du måste ange ett förnamn")]
        [StringLength(20, ErrorMessage = "Ditt namn kan inte vara längre än 20 tecken")]
        public string Name { get; set; }

        [Display(Name = "Ålder")]
        [Required(ErrorMessage = "Ålder måste anges")]
        [Range(0, 120, ErrorMessage = "Din ålder måste vara mellan 0 och 120")]
        public int? Age { get; set; }
    }
}
