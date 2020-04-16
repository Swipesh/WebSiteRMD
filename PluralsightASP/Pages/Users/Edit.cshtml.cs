using System.Threading;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Users
{
    [Authorize(Roles="Administrator")]
    public class EditModel : PageModel
    {
        private readonly UserStore _userStore;

        public User User { get; set; }
        public EditModel(UserStore userStore)
        {
            _userStore = userStore;
        }
        
        public IActionResult OnGet(string userId)
        {
           
            //User = _userStore.FindByIdAsync(userId,CancellationToken.None);
                
            if (User == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}