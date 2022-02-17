﻿using JobManager.Models;
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
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand<Job> SelectedCommand { get; }

        private Job selectedJob;
        public Job SelectedJob 
        {
            get => selectedJob;
            set => SetProperty(ref selectedJob, value);
        }
        public JobListViewModel()
        {
            Title = "Jobs";
            Jobs = new ObservableRangeCollection<Job>();

            LoadJobs();

            RefreshCommand = new AsyncCommand(Refresh);
            SelectedCommand = new AsyncCommand<Job>(Selected);
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

            IsBusy = false;
        }

        public async void LoadJobs()
        {
            //IEnumerable<Job> jobs = await JobDataStore.GetJobs();
            //Jobs.AddRange(jobs);

            var jobs = new List<Job>() {
                new Job { Id = 1, Name = "Job A Local Json File" , Description = "This is job a."},
                new Job { Id = 2, Name = "Job B Local Json File" , Description = "This is job b."},
                new Job { Id = 3, Name = "Job C Local Json File" , Description = "This is job c."},
                new Job { Id = 4, Name = "Job D Local Json File" , Description = "This is job d."}

            };

            Jobs.AddRange(jobs);
        }
    }
}
