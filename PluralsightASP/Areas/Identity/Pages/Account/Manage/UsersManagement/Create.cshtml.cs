using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PluralsightASP.Core;
using PluralsightASP.Data;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    [Authorize(Roles = "admin")]
    public class CreateModel : PageModel
    {
        private readonly UserManager<User> _userManager;

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [ExRequired]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email")]
            public string Email { get; set; }
            
            [ExRequired]
            [DataType(DataType.Text)]
            [ExStringLength(100, MinimumLength = 2)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [ExRequired]
            [DataType(DataType.Text)]
            [ExStringLength(100,/* ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", */MinimumLength = 2)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [ExRequired]
            [ExStringLength(100, MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [ExCompare("Password")]
            public string ConfirmPassword { get; set; }
        }
        
        [TempData]
        public string StatusMessage { get; set; }
        public CreateModel(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = Input.Email, Email = Input.Email ,FirstName = Input.FirstName,LastName =  Input.LastName};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    StatusMessage = "User has been created successfully";
                    return RedirectToPage("UsersList");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
    }
}
