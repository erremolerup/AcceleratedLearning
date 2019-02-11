using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemNet.Models
{
    public class Contact
    {
        //public int Id { get; set; }

        //Namn på användaren
        [Required(ErrorMessage = "Field can't be empty")]
        public string Name { get; set; }

        //Användarens email
        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress(ErrorMessage ="sss")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Email format is wrong")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email Format is wrong!!!")]
        public string Email { get; set; }
    }
}
