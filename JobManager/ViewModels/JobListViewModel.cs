using JobManager.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.ViewModels
{
    class JobListViewModel: JobManagerBase
    {
        public ObservableRangeCollection<Job> Jobs { get; set; }
        public AsyncCommand RefreshCammand { get; }
        public AsyncCommand<Job> SelectedCammand { get; }

        private Job selectedJob;
        public Job SelectedJob 
        {
            get => selectedJob;
            set => SetProperty(ref selectedJob, value);
        }
        public JobListViewModel()
        {
            Title = "Jobs";

            RefreshCammand = new AsyncCommand(Refresh);
            SelectedCammand = new AsyncCommand<Job>(Selected);
        }

        private async Task Selected(Job job)
        {
            // not implimented
        }

        public async Task Refresh()
        {
            IsBusy = true;
            Jobs.Clear();
            LoadJobs();
        }

        public async void LoadJobs()
        {
            IEnumerable<Job> jobs = await JobDataStore.GetJobs();
            Jobs.AddRange(jobs);
        }
    }
}
