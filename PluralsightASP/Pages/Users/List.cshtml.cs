using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Users
{
    public class ListModel : PageModel
    {

        private readonly IConfiguration _configuration;
        private readonly IUsersData _usersData;
        public IEnumerable<User> Users { get; set; }

        public ListModel(IConfiguration configuration, IUsersData usersData)
        {
            _configuration = configuration;
            _usersData = usersData;
        }
        public void OnGet()
        {
            Users = _usersData.GetAll();
        }
    }
}