using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TeamsFix
{
    public class ClearTeams
    {
        public static void EndProcesses(string processName)
        {
            // classic teams 
            foreach (var process in Process.GetProcessesByName(processName))
            {
                try
                {
                    process.Kill();
                    Console.WriteLine("Killed process " + process.Id);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public static bool DeleteItemsRecursively(string path)
        {
            try
            {
                // Create a DirectoryInfo object for the specified path
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                // Delete all files in the directory
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    file.Delete();
                    Console.WriteLine("Deleted file: " + file.Name);
                }

                // Recursively delete subdirectories
                foreach (DirectoryInfo subDirectory in directoryInfo.GetDirectories())
                {
                    DeleteItemsRecursively(subDirectory.FullName);
                    subDirectory.Delete();
                    Console.WriteLine("Deleted directory: " + subDirectory.Name);
                }

                // If we reach this point, deletion was successful
                return true;

            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., permission issues, directory not found)
                Console.WriteLine("ERROR in deletion: " + ex);
                return false;
            }
        }
    }
}