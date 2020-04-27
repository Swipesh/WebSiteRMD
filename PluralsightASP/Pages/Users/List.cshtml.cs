using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using PluralsightASP.Core;

namespace PluralsightASP.Pages.Users
{
    public class ListModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ListModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public void OnGet()
        {
            
        }
    }
    
}