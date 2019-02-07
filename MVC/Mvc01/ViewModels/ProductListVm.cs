using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Mvc01.Models;

namespace Mvc01.ViewModels
{
    public class ProductListVm
    {
        public IEnumerable<SelectListItem> AllProducts { get; set; }
        public Product Product { get; set; }
    }
}
