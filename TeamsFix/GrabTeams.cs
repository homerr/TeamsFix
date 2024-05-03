using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace TeamsFix

{
    public class GrabTeams
    {
        public void DownloadFiles(string[] fileUrls, string downloadFolder)
        {
            Directory.CreateDirectory(downloadFolder); // Ensure the download folder exists

            using (WebClient webClient = new WebClient())
            {
                foreach (var fileUrl in fileUrls)
                {
                    string fileName = Path.GetFileName(fileUrl);
                    string filePath = Path.Combine(downloadFolder, fileName);

                    webClient.DownloadFile(fileUrl, filePath);
                    Console.WriteLine($"Downloaded {fileName}");
                }
            }
        }

        public void RunExecutable(string executablePath, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(executablePath, arguments)
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = startInfo };
            process.Start();

            // Use a thread to read the output to avoid blocking
            new Thread(() =>
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }).Start();
        }
    }
}