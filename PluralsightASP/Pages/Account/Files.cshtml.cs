using System.Threading.Tasks;
using GeekLearning.Storage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PluralsightASP.Pages.Account
{
    public class Files : PageModel
    {
        private readonly IStore localAssets;

        [BindProperty]
        public string Str { get; set; }
        public Files(IStorageFactory factory)
        {
            localAssets = factory.GetStore("Store2");
        }
        public async Task<IActionResult> OnGet()
        {
            var summary = await localAssets.ListAsync("", "*.txt", recursive: true, withMetadata: false);

            Str = await summary[0].ReadAllTextAsync();
            return Page();
        }
    }
}