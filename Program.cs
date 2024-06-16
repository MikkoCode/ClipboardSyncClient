using ClipboardSyncClient.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace ClipboardSyncClient
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ConfigurationService>()
                .AddSingleton<IClipboardService, ClipboardService>()
                .AddSingleton<IConfiguration>(provider => provider.GetRequiredService<ConfigurationService>().Configuration)
                .AddSingleton<Form1>()
                .AddHttpClient()
                .BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}