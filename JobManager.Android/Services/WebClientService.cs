using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using JobManager.Services;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Droid.Services
{
    public class WebClientService : IWebClientService
    {
        public async Task<string> GetString(string uri)
        {
            throw new NotImplementedException();
        }
    }
}