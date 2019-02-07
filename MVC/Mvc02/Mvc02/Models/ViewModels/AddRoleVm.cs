using System.ComponentModel.DataAnnotations;

namespace Mvc02.Models.ViewModels
{
    public class AddRoleVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string RoleName { get; set; }


       
    }
}
