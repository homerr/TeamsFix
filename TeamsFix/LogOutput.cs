using System;
using System.IO;

namespace TeamsFix
{
    public class Logger
    {
        private string logFilePath;

        public Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(logFilePath, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}