using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ClipboardSyncClient.Services
{
    public class ConfigurationService
    {
        public IConfiguration Configuration { get; }

        public ConfigurationService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public void SaveDeviceName(string deviceName)
        {
            var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            var json = File.ReadAllText(configFilePath);
            var jsonObj = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            jsonObj["DeviceName"] = deviceName;
            string output = JsonSerializer.Serialize(jsonObj, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configFilePath, output);
        }
    }
}