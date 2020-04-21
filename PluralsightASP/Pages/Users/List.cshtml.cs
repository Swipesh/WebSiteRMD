using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Users
{
    public class ListModel : PageModel
    {

        private readonly IConfiguration _configuration;
        private readonly IUserStore<User> _usersData;
        public IEnumerable<User> Users { get; set; }
        public User tempUser { get; set; }

        public ListModel(IConfiguration configuration, IUserStore<User> userStore )
        {
            _configuration = configuration;
            _usersData = userStore;
        }
        public void OnGet()
        {
            tempUser = _usersData.FindByIdAsync("user1",CancellationToken.None).Result;
        }
    }
}