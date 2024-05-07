using System;
using System.Net;
using System.IO;

namespace TeamsFix
{
    public class FileDownloader
    {
        public void DownloadFile(string url)
        {
            string tempPath = Path.GetTempPath();
            string fileName = "MSTeams-x64.msix";
            string fullPath = Path.Combine(tempPath, fileName);

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile(url, fullPath);
                    Console.WriteLine($"File downloaded successfully at {fullPath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}