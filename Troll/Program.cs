using System.Diagnostics;

namespace FreeOnixV3
{
    class Program
    {
        public static void OpenURL(string url)
        {
            if (!url.Contains("://")) url = "https://" + url;
            Process.Start("explorer", url);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Downloading Onix Client.");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("Download Complete!");
            Thread.Sleep(500);
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Preparing for install.");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Clear();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Installing Onix Client.");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Clear();
            }
            Thread.Sleep(2000);
            Console.WriteLine("Installation Complete.");
            Thread.Sleep(5);
            Console.Clear();
            Console.WriteLine("There was an error installing Onix Client");
            Console.WriteLine("Please purchase a new license from\nhttps://www.patreon.com/onixclient\n");
            Console.WriteLine("Press any key to go to the patreon page.");
            Console.ReadKey();
            OpenURL("https://patreon.com/onixclient");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("You're still here?");
            Thread.Sleep(6000);
            Console.Clear();
            Console.WriteLine("You're still here?!");
            Thread.Sleep(6000);
            Console.Clear();
            Thread.Sleep(10000);
            Console.WriteLine("Huh. Well, I guess you're not going to buy a license.");
            Thread.Sleep(6000);
            Console.Clear();
            Thread.Sleep(6000);
            Console.WriteLine("I guess I'll just have to delete your files.");
            Thread.Sleep(6000);
            
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("Deleting files.");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Clear();
            }
            Thread.Sleep(500);
            Console.WriteLine("Files deleted.");
            Thread.Sleep(6000);
            Console.Clear();
            Console.WriteLine("You're still here?");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(10000);
            Console.WriteLine("Saw that coming didn't you?");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Fine! You want to play on a cracked client?");
            Thread.Sleep(3000);
            Console.WriteLine("\nHere you go!");
            Thread.Sleep(500);
            Console.Clear();
            OpenURL("https://shattereddisk.github.io/rickroll/rickroll.mp4");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Fuck you.");
            Thread.Sleep(500);
            Console.WriteLine("\nPay for software or get rickroll'd.");
            Thread.Sleep(30000);
            Console.Clear();
        }
    }
}