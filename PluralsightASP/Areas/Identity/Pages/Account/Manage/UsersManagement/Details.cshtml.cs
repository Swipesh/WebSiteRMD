using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    public class DetailsModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        public DetailsModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public User User { get; set; }

        [TempData]
        public string StatusMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _userManager.FindByIdAsync(id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
