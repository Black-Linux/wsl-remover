using System;
using System.Diagnostics;
using System.Net;

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

            Console.WriteLine("Blacklinux WSL has been successfully removed. Press any Key to exit");
            Events.AwaitUntilKeyPressed();
        }
    }
}
