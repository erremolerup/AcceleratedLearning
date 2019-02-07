using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using CandyMVC.Models;

namespace CandyMVC.ViewModels
{
    public class ProductListVm
    {
        public IEnumerable<SelectListItem> AllProducts { get; set; }
        public ProductAttributes Product { get; set; }
    }
}
