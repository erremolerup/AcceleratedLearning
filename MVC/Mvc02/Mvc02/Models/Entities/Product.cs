using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc02.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obligatorisk")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obligatorisk")]
        [Range(0, 1000, ErrorMessage ="Priset måste vara mellan 0 och 1000")]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public bool ForSale { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
