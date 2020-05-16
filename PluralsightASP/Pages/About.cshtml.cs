using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;
namespace PluralsightASP.Pages
{
    public class AboutModel : PageModel
    {
        
        private IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public List<FileInfo> Files { get; set; }

        public AboutModel(IWebHostEnvironment hostingEnvironment,UserManager<User> userManager)
        {
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGet(string path)
        { 
            Files = new List<FileInfo>();
            var user = await _userManager.GetUserAsync(User);
            var path1 = Path.Combine(_hostingEnvironment.WebRootPath, user.Id);
            var temp = new DirectoryInfo(path);
            foreach (var file in temp.GetFiles())
            {
                Files.Add(file);
            }
            var fileBytes = System.IO.File.ReadAllBytes(path);

            //http://stackoverflow.com/questions/1176022/unknown-file-type-mime
            return File(fileBytes, "application/force-download");

            return Page();
        }

       
    }
}