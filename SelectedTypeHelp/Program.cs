using System;
using System.Threading;

namespace SelectedTypeHelp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "*** Client Loader.";

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            int Maximum = 3;

            string emailCorrect = "admin";
            string PassCorrect = "admin";
            string user = "Admin";
            string version = "1.0.0";
            string AdminRole = "Owner";
            string LifetimeVersion = "LifeTime";
            string ThreeZeroDaysVersion = "30";

            if (email == emailCorrect && password == PassCorrect)
            {
                Console.WriteLine("Welcome, " + user);
                Console.Title = "*** Client Loader. User: " + user + "." + " Role: " + AdminRole + "." + " Days: " + LifetimeVersion + "." + " Lastest version: " + version;
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("User: " + user);
                Console.WriteLine("Version: " + version);
                Console.Write("\n\n\n");
                Console.WriteLine("Inject?");
                Console.WriteLine("1 - yes");
                Console.WriteLine("2 - no (closing loader)");
                Console.WriteLine("What you select?:");
                string selected = Console.ReadLine();

                if (selected == "1")
                {
                    Console.WriteLine("Waiting for rust...");
                    Thread.Sleep(5000);
                    Console.WriteLine("Injecting....");
                    Thread.Sleep(10000);
                    Console.WriteLine("Injected!");
                    Console.Write("\n\n\n");
                    Console.WriteLine("Press any key for close loader.");
                    Console.ReadKey();

                } else
                {
                    Console.WriteLine("");
                }

                if (selected == "2")
                {
                    Console.Write("\n\n\n");
                    Console.WriteLine("Press any key for close loader.");
                    Console.ReadKey();
                }

            } else
            {
                Console.WriteLine("Login Failed. Email or password have errors.");
                Console.ReadKey();
            }
        }
    }
}