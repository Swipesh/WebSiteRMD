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
    [Authorize(Roles = "admin")]
    public class ListModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IConfiguration _configuration;
        private readonly IUserStore<User> _usersData;
        public IEnumerable<User> Users { get; set; }
        public User tempUser { get; set; }

        public ListModel(UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        
        public void OnGet()
        {
            /*User us = new User {Id = Guid.NewGuid().ToString(),UserName = "SLAVA"};
            var result = _userManager.CreateAsync(us, "Kovrik98!");
            tempUser = _userManager.Users.First(u => u.Id == "user1");
            _roleManager.CreateAsync(new IdentityRole("admin"));
            _userManager.AddToRoleAsync(_userManager.FindByNameAsync("SLAVA").Result, "admin").Wait();*/
            

            //tempUser = _usersData.FindByIdAsync("2",CancellationToken.None).Result;
        }
    }
}