using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamsFix
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ClearTeams.EndProcesses("msteams");
            ClearTeams.EndProcesses("ms-teams"); 
            ClearTeams.EndProcesses("Teams"); 
            foreach (var item in Variables.TeamsDirs)
            {
                ClearTeams.DeleteItemsRecursively(item);
            }

            MessageBox.Show("Teams cleanup has been run", "Cleanup Tool");
            Environment.Exit(0);
        }
    }
}