using System;
using System.Diagnostics;

namespace blocksniper_alpha {
    class emresTurboCli {
       static void Main(string[] args) {
             if (args.Length == 0)
                {
                    var versionString = Assembly.GetEntryAssembly()
                                                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                                .InformationalVersion
                                                .ToString();

                    Console.WriteLine($"botsay v{versionString}");
                    Console.WriteLine("-------------");
                    Console.WriteLine("\nUsage:");
                    Console.WriteLine("  botsay <message>");
                    return;   
       }
           PassToTurbo(string.Join(' ', args));
    }
    
        private void PassToTurbo(string turbCommands) {
            byte[] exeBytes = Properties.Resources.MyTestExe;
            string exeToRun = @"C:
        }
}


private void button_Click(object sender, EventArgs e)
{
    //creates a new file with a new name to execute a process
    byte[] exeBytes = Properties.Resources.MyTestExe;
    string exeToRun = @"C:\TEST\MyTestExe.exe";

    using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
    {
        exeFile.Write(exeBytes, 0, exeBytes.Length);
    }

    //using (Process exeProcess = Process.Start(exeToRun))
    //{
        //exeProcess.WaitForExit();
    //}
}
    
    
    
    using System;
using System.Diagnostics;
using System.IO;
using blocksniper_alpha.Properties;

namespace blocksniper_alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.GetEntryAssembly()
                                            .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                            .InformationalVersion
                                            .ToString();

                Console.WriteLine($"botsay v{versionString}");
                Console.WriteLine("-------------");
                Console.WriteLine("\nUsage:");
                Console.WriteLine("  botsay <message>");
                return;
            }
            PassToTurbo(string.Join(' ', args));
        }

        private void PassToTurbo(string turbCommands)
        {
            byte[] exeBytes = Properties.Resources.emresTurboCli;
            string turboCli = @"\\resources\\emres\\turbo\\turbo.exe";
            using (FileStream blocksniper-ops - cli = new FileStream(turboCli, FileMode.CreateNew))
            {
                blocksniper - ops - cli.Write(exeBytes, 0, exeBytes.Length);
            }

            string ProgramName = "blocksniper-ops-cli.exe";

        }
    }
}

using System.Diagnostics;

class Program
{
    static void Main()
    {
        LaunchCommandLineApp();
    }

    /// <summary>
    /// Launch the legacy application with some options set.
    /// </summary>
    static void LaunchCommandLineApp()
    {
        // For the example.
        const string ex1 = "C:\\";
        const string ex2 = "C:\\Dir";

        // Use ProcessStartInfo class.
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.CreateNoWindow = false;
        startInfo.UseShellExecute = false;
        startInfo.FileName = "dcm2jpg.exe";
        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

        try
        {
            // Start the process with the info we specified.
            // Call WaitForExit and then the using-statement will close.
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
        }
        catch
        {
            // Log error.
        }
    }
}
          