using System;
using System.Diagnostics;
using System.Reflection;
using System.Net;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace VRChatHeartRateMonitor
{
    internal class UpdateHandler
    {
        private const string GitHubRepoUrl = "https://api.github.com/repos/RichardVirgosky/VRChat-Heart-Rate-Monitor/releases/latest";

        public event Action<string, string, string> UpdateAvailable;
        public async void CheckForUpdates()
        {
            try
            {
                String currentVersion = HeartRateMonitor.GetAssemblyVersion();

                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("User-Agent", HeartRateMonitor.GetAssemblyTitle());

                    JObject latestReleaseInfo = JObject.Parse(await webClient.DownloadStringTaskAsync(new Uri(GitHubRepoUrl)));
                    string latestVersion = latestReleaseInfo["tag_name"].ToString();

                    if (latestVersion != currentVersion)
                    {
                        var exeAsset = latestReleaseInfo["assets"].FirstOrDefault(a => a["name"].ToString().EndsWith(".cer", StringComparison.OrdinalIgnoreCase));

                        if (exeAsset != null)
                            UpdateAvailable?.Invoke(exeAsset["browser_download_url"].ToString(), currentVersion, latestVersion);
                    }
                }
            }
            catch (Exception){}
        }

        public bool Update(string updateUrl)
        {
            try
            {
                string oldVersionDirectoryFilePath = Assembly.GetExecutingAssembly().Location;
                string oldVersionTmpDirectoryFilePath;

                do
                {
                    oldVersionTmpDirectoryFilePath = Path.Combine(Path.GetDirectoryName(oldVersionDirectoryFilePath), $"{Guid.NewGuid()}.exe");
                } while (File.Exists(oldVersionTmpDirectoryFilePath));

                string newVersionTmpFilePath;

                do
                {
                    newVersionTmpFilePath = Path.Combine(Path.GetDirectoryName(oldVersionDirectoryFilePath), $"{Guid.NewGuid()}.exe");
                } while (File.Exists(newVersionTmpFilePath));

                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("User-Agent", HeartRateMonitor.GetAssemblyTitle());

                    webClient.DownloadFile(updateUrl, newVersionTmpFilePath);
                }

                Process.Start(newVersionTmpFilePath, $"\"{oldVersionDirectoryFilePath}\" \"{oldVersionTmpDirectoryFilePath}\" \"{newVersionTmpFilePath}\"");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
