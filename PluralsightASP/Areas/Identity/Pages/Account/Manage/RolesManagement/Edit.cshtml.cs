using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.RolesManagement
{
    [Authorize(Roles = "admin")]
    public class EditModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public EditModel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty] public InputModel Input { get; set; }

        public class InputModel
        {
            public string Id { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 2)]
            [Display(Name = "Name")]
            public string Name { get; set; }
        }

        public IList<User> UsersInRole { get; set; } = new List<User>();
        [TempData] public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);


            if (role == null)
            {
                return NotFound();
            }

            Input = new InputModel {Id = role.Id, Name = role.Name};
            UsersInRole = _userManager.Users
                .Where(u => _userManager.IsInRoleAsync(u, role.Name).GetAwaiter().GetResult()).ToList();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string id, List<string> NewUsersRole)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (!ModelState.IsValid || role == null)
            {
                return Page();
            }
            
            role.Name = Input.Name;

            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                StatusMessage = "Role has been updated successfully";
                return RedirectToPage("RolesList");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return Page();
            /*foreach (var user in UsersInRole)
            {
                if ()
                await _userManager.RemoveFromRoleAsync(user, role.Name);
            }
                

            try
            {
                await _userManager.AddToRolesAsync(User, NewUsersRole);
                await _userManager.UpdateAsync(User);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(User.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }*/

        }

    private bool UserExists(string id)
            {
                return _userManager.FindByIdAsync(id).GetAwaiter().GetResult() != null;
            }
        }
    }