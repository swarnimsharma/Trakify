using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Trakify_Server.Modals
{
    public class ImageUploadResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public int ImageID { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FileSize { get; set; }
    }
}
