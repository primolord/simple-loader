using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "beta loader. Writed by primolord";

            Console.WriteLine("Hello! Welcome in Beta Loader of *** Client!");
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            string EmailCorrect = "admin";
            string PasswordCorrect = "admin";
            string user = "Admin";

            if (email == EmailCorrect && password == PasswordCorrect)
            {
                Console.WriteLine("Welcome, Admin");
                Console.ReadKey();
                Console.Clear();
            } else
            {
                Console.WriteLine("Email or password have error!");
                Console.WriteLine("Press any key for close loader");
                Console.ReadKey();
            }
            Console.WriteLine("You're logged in: " + user);
            Console.WriteLine("Days: You're using lifetime version!");

            Console.WriteLine("Inject?");
            Console.WriteLine("rust (type: rust)");
            Console.WriteLine("csgo (type: csgo)");
            Console.WriteLine("Select:");
            string selected = Console.ReadLine();

            if (selected == "rust")
            {
                Console.WriteLine("Waiting for RUST...");
                Thread.Sleep(5000);
                Console.WriteLine("Injecting...");
                Thread.Sleep(10000);
                Console.WriteLine("Injected!");
            } else
            {
                Console.WriteLine("");
            }
            if (selected == "csgo")
            {
                Console.WriteLine("Waiting for csgo...");
                Thread.Sleep(5000);
                Console.WriteLine("Injecting...");
                Thread.Sleep(10000);
                Console.WriteLine("Injected!");
            } else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Press any key for close loader...");
            Console.ReadKey();
        }
    }
}