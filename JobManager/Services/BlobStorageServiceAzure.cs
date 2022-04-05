using Azure.Storage.Blobs;
using System.IO;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class BlobStorageServiceAzure : IBlobStorageService
    {
        private readonly BlobServiceClient service = new BlobServiceClient(ConnectionString);

        private static string ConnectionString => "connectionstring";
        private static string Container => "studentnumber";

        public async Task<MemoryStream> DownloadStreamAsync(string name)
        {
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(name);

            if (blob.Exists())
            {
                var stream = new MemoryStream();
                await blob.DownloadToAsync(stream);

                stream.Position = 0;
                return stream;
            }

            return null;
        }

        public async Task UploadStreamAsync(string name, MemoryStream stream)
        {
            stream.Position = 0;
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(name);
            await blob.UploadAsync(stream);
        }
    }
}
