using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PluralsightASP.Areas.Science.Pages
{
    public class About : PageModel
    {
        [TempData]
        public string StatusMessage { get; set; }
        public void OnGet()
        {
           // StatusMessage = "Your profile has been updated";
        }
    }
}