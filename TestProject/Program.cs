using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Executing test command...");
        Process process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = "/c dir"; // This is a Windows command to list directory contents
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();

        Console.WriteLine(process.StandardOutput.ReadToEnd());
        process.WaitForExit();
    }
}
