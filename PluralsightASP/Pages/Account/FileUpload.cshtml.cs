using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PluralsightASP.Core;
using PluralsightASP.Data;
using File = PluralsightASP.Core.File;

namespace PluralsightASP.Pages.Account
{
    public class FileUpload : PageModel
    {
        private readonly IWebHostEnvironment _environment;
        private readonly PluralsightASPDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        
        public string FileName { get; set; }

        [BindProperty]
        public IFormFile File { get; set; }

        public FileUpload(IWebHostEnvironment environment,PluralsightASPDbContext dbContext,UserManager<User> userManager)
        {
            _environment = environment;
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public void OnGet()
        {
            
        }
        
        public void OnPost()
        {
            var path = Path.Combine(_environment.WebRootPath, "images", File.FileName);
            var stream = new FileStream(path, FileMode.Create);
            File.CopyToAsync(stream).Wait();
            
            FileName = File.FileName;
            var tempFile = new File
                {Id = Guid.NewGuid().ToString(), FileName = File.Name, FilePath = path, FileType = File.ContentType};
            _dbContext.Files.Add(tempFile);
            _dbContext.UsersFiles.Add(new UsersFiles{FileId = tempFile.Id,UserId = _userManager.GetUserAsync(User).Result.Id,User = _userManager.GetUserAsync(User).Result,File = tempFile});

            _dbContext.SaveChanges();
        }
    }
}