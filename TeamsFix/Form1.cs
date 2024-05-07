using System;
using System.IO;
using System.Windows.Forms;

namespace TeamsFix
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.SetOut(new TextBoxStreamWriter(logBox));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var executable in Variables.TeamsExe)
            {
                ClearTeams.EndProcesses(executable);
            }

            MessageBox.Show("The application may appear to freeze as it clears up files", "Notification");
            foreach (var item in Variables.TeamsDirs)
            {
                ClearTeams.DeleteItemsRecursively(item);
            }
            MessageBox.Show("Teams cleanup has been run. Check log output.", "Cleanup Tool");
        }

        private void teamsgrab_Click(object sender, EventArgs e)
        {
            FileDownloader downloader = new FileDownloader();
            downloader.DownloadFile("https://go.microsoft.com/fwlink/?linkid=2196106");
        }

        private void installteams_Click(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempPath();
            string teamsPath = tempPath + "MSTeams-x64.msix";
            MessageBox.Show(
                "Explorer will now open to the Temporary directory that the Teams installer is in. Double click it to install. Path is: " + teamsPath,
                "Opening File Explorer");
            ExplorerOpener opener = new ExplorerOpener();
            opener.OpenAndHighlightFile(teamsPath);
        }

        private void quit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}