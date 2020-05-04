using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;
using PluralsightASP.Data;

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

        [BindProperty] public User User { get; set; }

        public IList<IdentityRole> IdentityRoles { get; set; }

        public IList<string> OldUserRoles { get; set; }
        /*[BindProperty]
        public IList<string> NewUserRoles { get; set; }*/

        [TempData] public string StatusMessage { get; set; }

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

            IdentityRoles = _roleManager.Roles.ToList();
            OldUserRoles = await _userManager.GetRolesAsync(User);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(List<string> NewUserRoles)
        {
            if (!ModelState.IsValid || User == null)
            {
                return Page();
            }

            if (OldUserRoles.Count > 0)
                await _userManager.RemoveFromRolesAsync(User, OldUserRoles);

            try
            {
                await _userManager.AddToRolesAsync(User, NewUserRoles);
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