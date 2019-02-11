using HemNet.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HemNet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using HemNet.Models.ViewModels;

namespace HemNet.Controllers
{
    public class ContactController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public ContactController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        // GET: Contact form
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Subscribe(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            return View(contact);
        }
        
    }

}

