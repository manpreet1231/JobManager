using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManager.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return GetDefaultJobs();
        }
        private List<Job> GetDefaultJobs()
        {

            var jobs = new List<Job>() {
                new Job { Id = 1, Name = "Job A API" , Description = "This is api a."},
                new Job { Id = 2, Name = "Job B API" , Description = "This is api b."},
                new Job { Id = 3, Name = "Job C API" , Description = "This is api c."},
                new Job { Id = 4, Name = "Job D API" , Description = "This is api d."}

            };
            return jobs;
        }
    }
}
