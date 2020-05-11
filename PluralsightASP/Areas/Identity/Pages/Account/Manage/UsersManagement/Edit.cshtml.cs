using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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

        public EditModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }



        public class InputModel
        {
            public string Id { get; set; }
            [Required]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email")]
            public string UserName { get; set; }
            
            [Required]
            [DataType(DataType.Text)]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [DataType(DataType.PhoneNumber)]
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

            Input = new InputModel {Id = user.Id, UserName = user.UserName,FirstName = user.FirstName,LastName = user.LastName,EmailConfirmed = user.EmailConfirmed,PhoneNumber = user.PhoneNumber};

            IdentityRoles = _roleManager.Roles.ToList();
            OldUserRoles = await _userManager.GetRolesAsync(user);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
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
            
            if (OldUserRoles !=null && OldUserRoles.Count > 0)
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
            return RedirectToPage("UsersList");
        }

        private bool UserExists(string id)
        {
            return _userManager.FindByIdAsync(id).GetAwaiter().GetResult() != null;
        }
    }
}