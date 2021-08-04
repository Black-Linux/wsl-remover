using System;
using System.Diagnostics;
using System.Net;
using System.IO;

using KeyEvents;

namespace blacklinux_remover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Removing Blacklinux WSL... This can take some time...");

            string WslRemove = @"--unregister Blacklinux";
            Process.Start("wsl.exe", WslRemove);

            Directory.Delete(@"C:\Program Files\Blacklinux\WSL", true);
            File.Delete(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Blacklinux.lnk");
            File.Delete(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Remove Blacklinux.lnk");


            Console.WriteLine("Blacklinux WSL has been successfully removed. Press any Key to exit");
            Events.AwaitUntilKeyPressed();
        }
    }
}
