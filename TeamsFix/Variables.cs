using System;

namespace TeamsFix
{
    public class Variables
    {
        public static string LocalAppData  = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
        public static string[] TeamsDirs = {
            @LocalAppData  + "\\Microsoft\\Teams\\",
            @LocalAppData  + "\\Microsoft\\TeamsMeetingAddin\\",
            @LocalAppData  + "\\Microsoft\\SquirrelTemp\\",
            @LocalAppData  + "\\Microsoft\\Packages\\MSTeams_8wekyb3d8bbwe\\",
            @LocalAppData  + "\\Microsoft\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\",
            @LocalAppData  + "\\Microsoft\\OneAuth\\",
            @LocalAppData  + "\\Microsoft\\TokenBroker\\",
            @LocalAppData  + "\\Microsoft\\IdentityCache\\",
            @AppDataPath   + "\\Microsoft\\Teams"
        };

        public static string[] TeamsExe =
        {
            "ms-teams",
            "msteams",
            "Teams"
        };

        public static string TeamsInstaller = "https://go.microsoft.com/fwlink/?linkid=2196106";
    }
}