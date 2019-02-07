using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mvc02.Services
{
    public class AuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<bool> UserExist(string email)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(email);
            return user != null;
        }

        public async Task<bool> RoleExist(string roleName)
        {
            IdentityUser user = await _userManager.FindByNameAsync(roleName);
            return user != null;
        }

        // din kod här
    }
}
