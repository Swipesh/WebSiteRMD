using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Areas.Admin.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly PluralsightASP.Data.PluralsightAspDbContext _context;

        public IndexModel(PluralsightASP.Data.PluralsightAspDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
