using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PluralsightASP.Areas.Education.Pages
{
    public class Materials : PageModel
    {
        [TempData]
        public string StatusMessage { get; set; }
        public void OnGet()
        {
            //StatusMessage = "Your profile has been updated";
        }
    }
}