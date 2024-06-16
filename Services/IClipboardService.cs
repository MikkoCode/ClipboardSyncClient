using ClipboardSyncClient.Models;
using System.Threading.Tasks;

namespace ClipboardSyncClient.Services
{
    public interface IClipboardService
    {
        Task<string> UpdateClipboardAsync(string device, string data, string deviceName);
        Task<ApiResponse<ClipboardData>> GetClipboardAsync(string device);
    }
}