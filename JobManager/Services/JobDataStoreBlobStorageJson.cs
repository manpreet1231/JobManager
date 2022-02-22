using JobManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreBlobStorageJson : IJobDataStore<Job>
    {
        //private readonly BlobServiceClient service = new BlobServiceClient(ConnectionString);
        private static string ConnectionString = "DefaultEndpointsProtocol=[http|https];AccountName=myAccountName;AccountKey=myAccountKey";
        public Task AddJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetJob(int jobId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetJobs()
        {
            throw new NotImplementedException();
        }

        public Task UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
