
using System.Threading.Tasks;

namespace JobManager.Services
{
    public interface IWebClientService
    {
        Task<string> GetString(string uri);
    }
}
