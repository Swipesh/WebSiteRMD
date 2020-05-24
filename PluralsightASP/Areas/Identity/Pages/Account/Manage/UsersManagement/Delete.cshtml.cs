using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.WindowsAzure.Storage.Blob;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    [Authorize(Roles = "admin")]
    public class DeleteModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly CloudBlobClient _client;

        public DeleteModel(UserManager<User> userManager, CloudBlobClient client)
        {
            _userManager = userManager;
            _client = client;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _userManager.FindByIdAsync(id);

            if (User != null && User!=await _userManager.GetUserAsync(HttpContext.User))
            {
                await _userManager.DeleteAsync(User);
                var container = _client.GetContainerReference(User.Id);
                await container.DeleteIfExistsAsync();
                StatusMessage = "User has been deleted successfully";
            }

            return RedirectToPage("./UsersList");
        }
    }
}
