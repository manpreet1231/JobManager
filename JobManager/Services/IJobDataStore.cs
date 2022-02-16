using JobManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    public interface IJobDataStore<T>
    {
        Task<IEnumerable<Job>> GetJobs();
        Task<Job> GetJob(string jobId);
        Task AddJob(Job job);
        Task UpdateJob(Job job);
        Task DeleteJob(Job job);
    }
}
