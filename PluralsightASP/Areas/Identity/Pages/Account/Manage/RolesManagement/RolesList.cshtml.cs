using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.RolesManagement
{
    /*[Authorize(Roles = "admin")]*/
    public class RolesList : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public IList<IdentityRole> Roles { get; set; }
        
        [TempData]
        public string StatusMessage { get; set; }

        public RolesList(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public void OnGet()
        {
            Roles = _roleManager.Roles.ToList();
        }
    }
}