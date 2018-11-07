1) In your application project, go to Properties/Resources.
(2) Click on Add Resource.
(3) Select "Add Existing File.."
(4) Browse to the .exe you want to embed, select it and click "Open".
(5) If you want to change the resource name:
    In the Resource Editor, right-click the exe you added and select "rename" and enter an appropriate name.
    In this example, I called it "MyTestExe".
(6) Where you want to extract and run the executable, add code like this:

private void button_Click(object sender, EventArgs e)
{
    byte[] exeBytes = Properties.Resources.MyTestExe;
    string exeToRun = @"C:\TEST\MyTestExe.exe";

    using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
    {
        exeFile.Write(exeBytes, 0, exeBytes.Length);
    }

    using (Process exeProcess = Process.Start(exeToRun))
    {
        exeProcess.WaitForExit();
    }
}