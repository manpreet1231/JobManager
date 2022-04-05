using System;
using System.Collections.Generic;
using System.Text;
using JobManager.Models;

namespace JobManager.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
