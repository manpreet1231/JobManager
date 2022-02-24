using JobManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JobManager.Services
{
    public class IJobDataStoreAPI : IJobDataStore<Job>
    {
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

        public async Task<IEnumerable<Job>> GetJobs()
        {
            var service = DependencyService.Get<IWebClientService>();
            var jsonString = await service.GetString("http://localhost:3074/Jobs");
            var jobs = JsonConvert.DeserializeObject<List<Job>>(jsonString);
            return jobs;
            //throw new NotImplementedException();
        }

        public Task UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
