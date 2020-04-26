using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Pages
{
    public class Logout : PageModel
    {
        private readonly SignInManager<User> _signInManager;

        public void OnGet()
        {
        }

        public Logout(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        
        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("Index");
        }
    }
}