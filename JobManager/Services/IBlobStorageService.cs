using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    public interface IBlobStorageService
    {
      
        Task UploadStreamAsync(string name, MemoryStream stream);
        Task<MemoryStream> DownloadStreamAsync(string name);

    }
}