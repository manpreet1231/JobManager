using System;
using System.Collections.Generic;
using System.Text;

namespace JobManager.ViewModels
{
    [QueryProperty(nameof(JobId),nameof(JobId))]
    internal class JobDetailViewModel: JobManagerBase
    {
        private int jobId;
        public int JobId
        {
            get { return jobId; }
            set { 
                jobId = value;
                LoadJob(value);
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

    }
}
