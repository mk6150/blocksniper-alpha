using System;
using System.Diagnostics;
using blocksniper_alphav5.Properties;
using System.IO;

namespace blocksniper_alphav5
{
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
            //const string ex1 = "C:\\";
            //const string ex2 = "C:\\Dir";

            // Use ProcessStartInfo class.
            Process turboCliProc = new Process();
            turboCliProc.StartInfo.CreateNoWindow = false;
            turboCliProc.StartInfo.UseShellExecute = false;
            turboCliProc.StartInfo.FileName = "C:\\code\\vs2017\\projects\\blocksniper-alphav5\\resources\\emres\\turbo\\turbo.exe";
            turboCliProc.StartInfo.Arguments = "\"containers\"";


            // Use ProcessStartInfo class.
            //Process startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = false;
            //startInfo.FileName = "C:\\code\\vs2017\\projects\\blocksniper-alphav5\\resources\\emres\\turbo\\turbo.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Normal;
            //startInfo.Arguments = "turbo containers";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                //using (Process exeProcess = Process.Start(startInfo))
                //{
                //exeProcess.WaitForExit();
                //}

                turboCliProc.Start();
            }
            catch
            {
                // Log error.
            }
        }
    }
}

