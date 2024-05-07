using System.Diagnostics;

namespace TeamsFix
{
    public class ExplorerOpener
    {
        public void OpenAndHighlightFile(string filePath)
        {
            string argument = "/select, \"" + filePath + "\"";

            Process.Start("explorer.exe", argument);
        }
    }
}