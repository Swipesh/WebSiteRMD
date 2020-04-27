using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;
using PluralsightASP.Data;
using Microsoft.AspNetCore.Identity;

namespace PluralsightASP.Pages.Account
{
    public class Profile : PageModel
    {
        private readonly UserManager<User> _userManager;
        
        public User CurrentUser { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        
        [BindProperty]
        public string LastName { get; set; }
        
        [BindProperty]
        public string Email { get; set; }

        public Profile(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGet()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToPage("Login");
            CurrentUser =  await _userManager.GetUserAsync(User);
            if (CurrentUser != null)
            {
                FirstName = CurrentUser.FirstName;
                LastName = CurrentUser.LastName;
                Email = CurrentUser.Email;
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                CurrentUser = await _userManager.GetUserAsync(User);
                CurrentUser.FirstName = FirstName;
                CurrentUser.LastName = LastName;
                CurrentUser.Email = Email;
                var result = await _userManager.UpdateAsync(CurrentUser);
            }

            return RedirectToPage("../Index");
        }

        
    }
}