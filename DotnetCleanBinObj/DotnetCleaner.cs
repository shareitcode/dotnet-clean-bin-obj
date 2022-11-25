using System.Diagnostics;

namespace DotnetCleanBinObj
{
    internal static class DotnetCleaner
    {
        public static void CleanBinObjFolders()
        {
            var processStart = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = "Get-ChildItem .\\ -include bin,obj -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }",
                CreateNoWindow = true
            };
            Process.Start(processStart);
            Console.WriteLine("Folders cleaned!");
        }
    }
}