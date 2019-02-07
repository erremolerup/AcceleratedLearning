using Microsoft.AspNetCore.Mvc;
using Mvc02.Models.ViewModels;
using Mvc02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mvc02.Controllers
{
    public class AdminController : Controller
    {
        private readonly AuthService _auth;

        public AdminController(AuthService auth)
        {
            _auth = auth;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddRoleForUser(AddRoleVm addrole)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            bool userexist = await _auth.UserExist(addrole.Email);

            bool roleexist = await _auth.RoleExist(addrole.RoleName);

            if (!userexist)
            {
                ModelState.AddModelError("UserDontExist", $"User with email {addrole.Email} doesn't exist");
                return View("Index");
            }

            else
            {
                return View("SuccessAddRole", addrole);

            }

        }
        
    }
}
