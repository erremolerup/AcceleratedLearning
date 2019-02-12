using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HemNet.Data;
using Microsoft.AspNetCore.Mvc;
using HemNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace HemNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SiteConfig _siteConfig;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(ApplicationDbContext context, SiteConfig siteConfig, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _siteConfig = siteConfig;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Migrate()
        {
            _context.Database.Migrate();
            ViewData["Message"] = "Database migrated";
            return View("Index");
        }

        public IActionResult FelFelFel()
        {
            throw new Exception("fel, fel, fel!!");
        }

        public IActionResult SiteConfig()
        {
            return Ok(_siteConfig);
        }

        public IActionResult IHosting()
        {
            return Ok(_hostingEnvironment);
        }

        public IActionResult Recreate()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            ViewData["Message"] = "Database recreated";
            return View("Index");
        }

        public IActionResult Seed()
        {
            _context.Apartments.RemoveRange(_context.Apartments);
            _context.HousingCooperatives.RemoveRange(_context.HousingCooperatives);

            var hc1 = new HousingCooperative
            {
                Name = "HSB Brf-Karlavagnen",
                Description = "Vi är en aktiv Bostadsrätt förening med god ekonomi. Vi finns i området Molnvädersgatan – Önskevädersgatan"
            };

            var hc2 = new HousingCooperative
            {
                Name = "Brf Skanstorget",
                Description = "Bostadsrättsföreningen Skanstorget i Göteborg är belägen i centrala Göteborg med Linné, Haga och Vasastan som grannar."
            };

            _context.Apartments.Add(new Apartment
            {
                ApartmentNumber = 3,
                HousingCooperative = hc2,
                OperatingCost = 2300,
                Price = 2200000,
                Rent = 1800,
                Size = 75,
                Rooms = 3
            });

            _context.Apartments.Add(new Apartment
            {
                ApartmentNumber = 1,
                HousingCooperative = hc1,
                OperatingCost = 1800,
                Price = 2000000,
                Rent = 3400,
                Size = 47,
                Rooms = 2.5M
            });

            _context.Apartments.Add(new Apartment
            {
                ApartmentNumber = 2,
                HousingCooperative = hc1,
                OperatingCost = 1975,
                Price = 2500000,
                Rent = 3800,
                Size = 53,
                Rooms = 3
            });


            _context.SaveChanges();
            ViewData["Message"] = "Seeding done";
            return View("Index");
        }

    }
}
