using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMVC.ViewModels
{
    public class WeatherVm
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public List<TimeTemp> TimeTemp { get; set; }
    }
}
