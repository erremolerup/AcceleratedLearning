
using System.ComponentModel.DataAnnotations;


namespace HemNet.Models.ViewModels
{
    public class SubscribeVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
