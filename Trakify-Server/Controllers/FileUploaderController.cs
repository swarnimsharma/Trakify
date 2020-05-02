using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Trakify_Server.Controllers
{
    public class FileUploaderController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            var fileNames = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location

                    var fileName = Path.GetFileName(formFile.FileName);
                    var _ext = Path.GetExtension(formFile.FileName);
                    var uniqueString = Guid.NewGuid().ToString();
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", uniqueString + _ext);
                    filePaths.Add(filePath);
                    fileNames.Add(uniqueString + _ext);


                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePaths, fileNames });
        }
    }
}