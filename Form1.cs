using ClipboardSyncClient.Models;
using ClipboardSyncClient.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardSyncClient
{
    public partial class Form1 : Form
    {
        private readonly IClipboardService _clipboardService;
        private readonly IConfiguration _configuration;
        private readonly ConfigurationService _configurationService;
        private static string LocalFilePath;
        private List<string> clipboardHistory = new List<string>();
        private string deviceName = "Undefined Device";

        public Form1(IClipboardService clipboardService, IConfiguration configuration, ConfigurationService configurationService)
        {
            InitializeComponent();
            _clipboardService = clipboardService;
            _configuration = configuration;
            _configurationService = configurationService;
            LocalFilePath = configuration["LocalFilePath"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDeviceName();
            LoadClipboardHistory();
        }

        private void LoadDeviceName()
        {
            deviceName = _configuration["DeviceName"] ?? "Undefined Device";
            textBoxDeviceName.Text = deviceName;
        }

        private void SaveDeviceName(string name)
        {
            _configurationService.SaveDeviceName(name);
            deviceName = name;
        }

        private void CopyToClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        private string GetFromClipboard()
        {
            return Clipboard.GetText();
        }

        private void Log(string message)
        {
            textBoxLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }

        private void AddToHistory(string message)
        {
            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var entry = $"{timestamp}: {message}";
            clipboardHistory.Add(entry);
            listBoxHistory.Items.Add(entry);
            SaveClipboardHistory();
        }

        private void LoadClipboardHistory()
        {
            if (File.Exists(LocalFilePath))
            {
                var json = File.ReadAllText(LocalFilePath);
                clipboardHistory = JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
                listBoxHistory.Items.AddRange(clipboardHistory.ToArray());
            }
        }

        private void SaveClipboardHistory()
        {
            var json = JsonSerializer.Serialize(clipboardHistory);
            File.WriteAllText(LocalFilePath, json);
        }

        private async void btnSendClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                var text = GetFromClipboard();
                Log($"Sending clipboard data: {text}");
                var response = await _clipboardService.UpdateClipboardAsync("pc", text, deviceName);
                Log($"Server response: {response}");
                lblStatus.Text = "Clipboard data sent to server.";
                AddToHistory($"Sent clipboard data from {deviceName} pc");
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                Log($"Error sending clipboard data: {ex.Message}");
            }
        }

        private async void btnRetrieveFromServer_Click(object sender, EventArgs e)
        {
            await RetrieveClipboardDataAsync();
        }

        private async Task RetrieveClipboardDataAsync()
        {
            try
            {
                Log("Retrieving clipboard data from server");
                var response = await _clipboardService.GetClipboardAsync("pc");
                Log($"Server response: {JsonSerializer.Serialize(response)}");
                textBoxClipboard.Text = response.Data.Data;
                lblSource.Text = $"Source: {response.Data.DeviceName}";
                lblStatus.Text = "Retrieved from server.";
                AddToHistory($"Retrieved \"{response.Data.Data}\" from {response.Data.DeviceName} pc");
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                Log($"Error retrieving clipboard data: {ex.Message}");
            }
        }

        private void btnSaveDeviceName_Click(object sender, EventArgs e)
        {
            var name = textBoxDeviceName.Text;
            SaveDeviceName(name);
            Log($"Device name saved: {name}");
        }
    }
}
