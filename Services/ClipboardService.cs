using ClipboardSyncClient.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClipboardSyncClient.Services
{
    public class ClipboardService : IClipboardService
    {
        private readonly HttpClient _client;
        private readonly string _serverUrl;

        public ClipboardService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _serverUrl = configuration["ServerUrl"];
        }

        public async Task<string> UpdateClipboardAsync(string device, string data, string deviceName)
        {
            var clipboardData = new ClipboardData { Device = device, Data = data, DeviceName = deviceName };
            var json = JsonSerializer.Serialize(clipboardData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_serverUrl, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            return responseContent;
        }

        public async Task<ApiResponse<ClipboardData>> GetClipboardAsync(string device)
        {
            var response = await _client.GetStringAsync($"{_serverUrl}?device={device}");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var clipboardData = JsonSerializer.Deserialize<ApiResponse<ClipboardData>>(response, options);
            return clipboardData;
        }
    }
}