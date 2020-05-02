using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Data;

namespace PluralsightASP.Pages.Account
{
    public class GetFile : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly PluralsightAspDbContext _dbContext;

        public GetFile(IWebHostEnvironment environment,PluralsightAspDbContext dbContext)
        {
            _environment = environment;
            _dbContext = dbContext;
        }
        public IActionResult OnGet()
        {
            //var file = _dbContext.Files
            // Путь к файлу
            string file_path = Path.Combine(_environment.WebRootPath, "images/image1.jpg");
            // Тип файла - content-type
            string file_type = "image/jpeg";
            // Имя файла - необязательно
            string file_name = "image1.jpg";
            return PhysicalFile(file_path, file_type, file_name);
        }
    }
}