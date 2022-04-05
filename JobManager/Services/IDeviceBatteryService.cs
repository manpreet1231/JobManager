using JobManager.Models;

namespace JobManager.Services
{
    public interface IDeviceBatteryService
    {
        DeviceBattery GetBattery();
    }
}
