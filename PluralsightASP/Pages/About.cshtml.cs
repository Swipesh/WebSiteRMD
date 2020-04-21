using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PluralsightASP.Pages
{
    public class AboutModel : PageModel
    {
        
        private IWebHostEnvironment _hostingEnvironment;

        public string FileName { get; set; }

        public AboutModel(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnGet()
        {

        }

        public void OnPost(IFormFile photo)
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "images", photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream).Wait();
            FileName = photo.FileName;
        }
    }
}