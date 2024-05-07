# Really basic Teams cleanup

This application was made to solve an issue around cleaning up broken credentials following Tenant>Tenant migrations.

All this script does can be achieved with a batch file, but most places will disallow the use of these, and or access to the command line - hence, why I quickly made this. 

It remains a work in progress, you'll be able to tell I'm not a professional coder, so use at your own risk!

Happy to take any PR's into the code

## What it does

- Kills any teams processes
- Cleans up all traces of the Classic teams from the local profile
- Removes all cached credentials for authentication from the local profile

### Paths

It will clean up these locations;

```
    string[] teamsDirs = {
        @localAppData + "\\Microsoft\\Teams\\",
        @localAppData + "\\Microsoft\\TeamsMeetingAddin\\",
        @localAppData + "\\Microsoft\\SquirrelTemp\\",
        @localAppData + "\\Microsoft\\Packages\\MSTeams_8wekyb3d8bbwe\\",
        @localAppData + "\\Microsoft\\Packages\\Microsoft.AAD.BrokerPlugin_cw5n1h2txyewy\\",
        @localAppData + "\\Microsoft\\OneAuth\\",
        @localAppData + "\\Microsoft\\TokenBroker\\",
        @localAppData + "\\Microsoft\\IdentityCache\\"
    };

```

### Processes

It will kill these processes;

```
msteams
ms-teams
Teams
```

## To Do

-  [ ] Add option to remove Teams wide installer (will require admin rights)
-  [x] Add functionality to download and install "New Teams" if not present