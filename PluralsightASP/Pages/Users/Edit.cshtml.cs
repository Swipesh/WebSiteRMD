using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Users
{
    public class EditModel : PageModel
    {
        private readonly IUsersData _usersData;

        public User User { get; set; }
        public EditModel(IUsersData usersData)
        {
            _usersData = usersData;
        }
        
        public IActionResult OnGet(int? userId)
        {
            if (userId.HasValue)
            {
                User = _usersData.GetById(userId.Value);
            }
            else
            {
                User = new User();
            }
            if (User == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}