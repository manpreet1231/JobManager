using MvvmHelpers;
using JobManager.Services;
using Xamarin.Forms;
using JobManager.Models;

namespace JobManager.ViewModels
{
    public class JobManagerBase : BaseViewModel
    {
        public IJobDataStore<Job> JobDataStore => DependencyService.Get<IJobDataStore<Job>>();
    }
}
