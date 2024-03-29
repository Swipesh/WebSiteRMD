using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using PluralsightASP.Core;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage
{
    [Authorize]
    public class Files : PageModel
    {
        private readonly CloudBlobClient _client;
        private readonly UserManager<User> _userManager;

        public List<string> Blobs { get; set; }
        [TempData]
        public string StatusMessage { get; set; }

        public Files(CloudBlobClient client, UserManager<User> userManager)
        {
            _client = client;
            _userManager = userManager;
            Blobs = new List<string>();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var container = _client.GetContainerReference(user.Id);

            
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

        public async Task<IActionResult> OnGetDownloadFileAsync(string fileName)
        {
            var user = await _userManager.GetUserAsync(User);
            var ms = new MemoryStream();


            var container = _client.GetContainerReference(user.Id);

            if (await container.ExistsAsync())
            {
                var file = container.GetBlobReference(fileName);

                if (await file.ExistsAsync())
                {
                    await file.DownloadToStreamAsync(ms);
                    Stream blobStream = file.OpenReadAsync().Result;
                    return File(blobStream, file.Properties.ContentType, file.Name);
                }
                else
                {
                    return Content("File does not exist");
                }
            }
            else
            {
                return Content("Container does not exist");
            }
        }

        public async Task<IActionResult> OnPostAsync(IFormFile asset)
        {
            if (asset == null)
            {
                StatusMessage = "Nothing to upload";
                return RedirectToPage();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var container = _client.GetContainerReference(user.Id);
                if (await container.ExistsAsync())
                {
                    var blockBlob = container.GetBlockBlobReference(asset.FileName);
                    await blockBlob.UploadFromStreamAsync(asset.OpenReadStream());
                }
            }
            
            return RedirectToPage();
        }
    }
}