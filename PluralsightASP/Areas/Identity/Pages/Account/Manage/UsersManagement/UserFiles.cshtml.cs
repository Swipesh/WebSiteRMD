using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.WindowsAzure.Storage.Blob;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage.UsersManagement
{
    [Authorize(Roles = "admin")]
    public class UserFiles : PageModel
    {
        private readonly CloudBlobClient _client;
        private readonly UserManager<User> _userManager;

        public List<string> Blobs { get; set; }


        public string Id { get; set; }
        [TempData] public string StatusMessage { get; set; }

        public UserFiles(CloudBlobClient client, UserManager<User> userManager)
        {
            _client = client;
            _userManager = userManager;
            Blobs = new List<string>();
        }

        public async Task<IActionResult> OnGet(string id)
        {
            Id = id;
            var container = _client.GetContainerReference(id);

            if (!await container.ExistsAsync())
                return Content("Container does not exist");

            foreach (IListBlobItem item in container.ListBlobsSegmentedAsync(null, new BlobContinuationToken())
                .GetAwaiter().GetResult().Results)
            {
                if (item.GetType() == typeof(CloudBlockBlob))
                {
                    CloudBlockBlob blob = (CloudBlockBlob) item;
                    Blobs.Add(blob.Name);
                }
                else if (item.GetType() == typeof(CloudPageBlob))
                {
                    CloudPageBlob blob = (CloudPageBlob) item;
                    Blobs.Add(blob.Name);
                }
                else if (item.GetType() == typeof(CloudBlobDirectory))
                {
                    CloudBlobDirectory dir = (CloudBlobDirectory) item;
                    Blobs.Add(dir.Uri.ToString());
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnGetDownloadFileAsync(string id, string fileName)
        {
            Id = id;
            var user = await _userManager.FindByIdAsync(id);
            var ms = new MemoryStream();


            var container = _client.GetContainerReference(user.Id);

            if (!await container.ExistsAsync())
                return Content("Container does not exist");


            var file = container.GetBlobReference(fileName);

            if (!await file.ExistsAsync())
                return Content("File does not exist");

            await file.DownloadToStreamAsync(ms);
            Stream blobStream = file.OpenReadAsync().Result;
            return File(blobStream, file.Properties.ContentType, file.Name);
        }

        public async Task<IActionResult> OnPostAsync(string id, IFormFile asset)
        {
            Id = id;
            if (asset == null)
            {
                StatusMessage = "Nothing to upload";
                return RedirectToPage();
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return RedirectToPage();
            var container = _client.GetContainerReference(user.Id);
            if (!await container.ExistsAsync())
                return RedirectToPage();

            var blockBlob = container.GetBlockBlobReference(asset.FileName);
            await blockBlob.UploadFromStreamAsync(asset.OpenReadStream());

            return RedirectToPage();
        }
    }
}