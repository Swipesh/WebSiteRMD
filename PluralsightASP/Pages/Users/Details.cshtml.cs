using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly PluralsightASP.Data.PluralsightAspDbContext _context;

        public DetailsModel(PluralsightASP.Data.PluralsightAspDbContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
