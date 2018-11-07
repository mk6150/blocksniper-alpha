using System;
using System.Diagnostics;

namespace botsay { //change when file is built
    class baseImage 
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                var versionString = Assembly.xx();
                                            .xx();
                                            .ToString();
                //tool usage
                Console.WriteLine($"toolname v{versionString}");
                return;
            }

            PassToTurb(string.Join(' ', args));
        }

        static void PassToTurb(string cmdLineInput)
        {
            string ProgramName = "turbo.exe";
            Process process = new Process();
            process.StartInfo.FileName = ProgramName;
            process.StartInfo.Arguments = cmdLineInput;
            process.Start();
        }
    }

}


/* Example Implementation:

using System.Diagnostics;

private void button1_Click(object sender, EventArgs e)
{
    string ProgramName = "winword.exe";
    Process.Start(ProgramName);
}

private void button1_Click(object sender, EventArgs e)
{
    string ProgramName = "winword.exe";
    Process process = new Process();
    process.StartInfo.FileName = ProgramName;
    process.StartInfo.Arguments="D:\\MyDocument.docx";
    process.Start();
}

Commands sent from the fabric CLI can be done via MarshallingObjects 
As seen here (https://docs.microsoft.com/en-us/dotnet/api/system.marshalbyrefobject?view=netcore-2.1)
and here where Process methods are referenced: (https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.process?view=netcore-2.1)
And via the Remoting Service Class which hasnt caught up to .NET Core Dependent on 4.7.2: (https://docs.microsoft.com/en-us/dotnet/api/system.runtime.remoting.remotingservices?view=netframework-4.7.2)

https://www.codeguru.com/code/legacy/cs_misc/CreatingAndUsing.zip

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/assemblies-gac/walkthrough-embedding-types-from-managed-assemblies-in-visual-studio

 */



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


          