// this is the entrypoint to interact with the system (interfaced for testing).
var machineManager = new MachineManager(
    "10.0.0.1",
    "Administrator",
    "password".ToSecureString(),
    autoManageTrustedHosts: true);

// will perform a user initiated reboot.
machineManager.Reboot();

// can run random script blocks WITH parameters.
var fileObjects = machineManager.RunScript("{ param($path) ls $path }", new[] { @"C:\PathToList" });
var fileObjectsWithTwoTypedParameters = machineManager.RunScript("{ param([string] $path, [string] $filter) ls -Path $path -Filter $filter }", new[] { @"C:\Windows", "*.exe" });

// can run random cmd.exe commands WITH parameters.
var output = machineManager.RunCmd("xcopy", new[] { "D:\\File.txt", "D:\\Folder\\" });

// can run scripts and cmd commands locally.
machineManager.RunScriptOnLocalhost(...);
machineManager.RunCmdOnLocalhost(...);

// can transfer files to AND from the remote server (over WinRM's protocol!).
var localFilePath = @"D:\Temp\BigFileLocal.nupkg";
var fileBytes = File.ReadAllBytes(localFilePath);
var remoteFilePath = @"D:\Temp\BigFileRemote.nupkg";

machineManager.SendFile(remoteFilePath, fileBytes);
var downloadedBytes = machineManager.RetrieveFile(remoteFilePath);