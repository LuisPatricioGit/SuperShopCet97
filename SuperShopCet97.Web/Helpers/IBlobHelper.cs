using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperShopCet97.Web.Helpers
{
    public interface IBlobHelper
    {
        //Default
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName);

        //Mobile
        Task<Guid> UploadBlobAsync(byte[] file, string containerName);
        
        //Other
        Task<Guid> UploadBlobAsync(string image, string containerName);

    }
}
