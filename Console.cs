using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MantleRPC.Handler;

namespace MantleRPC
{
    internal class Console
    {
        static void Main(string[] args)
        {
            System.Console.Title = "Mantle Rich Presence";
            checkProcess();


            void checkProcess()
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName("Mantle");
                    if (proc.Length == 0)
                    {
                        System.Console.WriteLine("Mantle.gg is not running. Please restart the app for Discord Presence to work!");
                        System.Console.ReadLine();
                    }
                    else
                    {
                        System.Console.WriteLine("Mantle.gg Rich Presence started!");
                        Discord.Start();
                        System.Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine($"Error occured. Error: {ex.Message}");
                }
            }
        }
    }
}
