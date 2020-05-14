using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LazZiya.ExpressLocalization.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    public class EditModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public EditModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [BindProperty] public InputModel Input { get; set; }


        public class InputModel
        {
            public string Id { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email")]
            public string UserName { get; set; }

            [ExRequired]
            [DataType(DataType.Text)]
            [ExStringLength(100,MinimumLength = 2)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [ExRequired]
            [DataType(DataType.Text)]
            [ExStringLength(100, MinimumLength = 2)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [DataType(DataType.PhoneNumber)] 
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            public bool EmailConfirmed { get; set; }
        }


        public IList<IdentityRole> IdentityRoles { get; set; } = new List<IdentityRole>();

        public IList<string> OldUserRoles { get; set; }

        [TempData] public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            Input = new InputModel
            {
                Id = user.Id, UserName = user.UserName, FirstName = user.FirstName, LastName = user.LastName,
                EmailConfirmed = user.EmailConfirmed, PhoneNumber = user.PhoneNumber
            };

            IdentityRoles = _roleManager.Roles.ToList();
            OldUserRoles = await _userManager.GetRolesAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, List<string> NewUserRoles)
        {
            var user = await _userManager.FindByIdAsync(id);
            OldUserRoles = await _userManager.GetRolesAsync(user);
            if (!ModelState.IsValid || User == null)
            {
                return Page();
            }

            user.UserName = Input.UserName;
            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            user.PhoneNumber = Input.PhoneNumber;
            user.EmailConfirmed = Input.EmailConfirmed;

            if (OldUserRoles != null && OldUserRoles.Count > 0)
                await _userManager.RemoveFromRolesAsync(user, OldUserRoles);

            try
            {
                await _userManager.AddToRolesAsync(user, NewUserRoles);
                await _userManager.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            StatusMessage = "User has been updated successfully";
            await _signInManager.RefreshSignInAsync(user);
            return RedirectToPage("UsersList");
        }

        private bool UserExists(string id)
        {
            return _userManager.FindByIdAsync(id).GetAwaiter().GetResult() != null;
        }
    }
}