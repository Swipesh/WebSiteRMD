using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    public class UsersList : PageModel
    {
        private readonly UserManager<User> _userManager;

        public IList<User> Users { get; set; }
        
        [TempData]
        public string StatusMessage { get; set; }

        public UsersList(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }
    }
}