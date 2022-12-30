using System.Diagnostics;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;

namespace FreeOnixV3
{
    class Program
    {
        public static void OpenURL(string url)
        {
            if (!url.Contains("://")) url = "https://" + url;
            Process.Start("explorer", url);
        }
        public static void OpenGame()
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "explorer.exe",
                Arguments = "shell:appsFolder\\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App",
            };
            process.StartInfo = startInfo;
            process.Start();
        }
        public static void CloseGame()
        {
            Process[] processes = Process.GetProcessesByName("Minecraft.Windows");
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }
        public static void createOption(string option, string description)
        {
            Console.Write("[");
            Console.Write(option, Color.MediumBlue);
            Console.Write("] ");
            Console.WriteLine(description, Color.White);
        }

        public static void delayedWrite(string text, int delay)
        {
            Thread.Sleep(delay);
            Console.WriteLine(text, Color.White);
        }
        static void Main(string[] args)
        {
        startUP:
            Console.Clear();
            Console.Title = "Onix Client Cracker 2.0";
            string logo = "\r  ____        _       _____ _ _            _      _____                _    \r\n / __ \\      (_)     / ____| (_)          | |    / ____|              | |   \r\n| |  | |_ __  ___  _| |    | |_  ___ _ __ | |_  | |     _ __ __ _  ___| | __\r\n| |  | | '_ \\| \\ \\/ / |    | | |/ _ \\ '_ \\| __| | |    | '__/ _` |/ __| |/ /\r\n| |__| | | | | |>  <| |____| | |  __/ | | | |_  | |____| | | (_| | (__|   < \r\n \\____/|_| |_|_/_/\\_\\\\_____|_|_|\\___|_| |_|\\__|  \\_____|_|  \\__,_|\\___|_|\\_\\\r\n                                                                            \r\n                                                                            ";
            Console.WriteLine(logo, Color.Blue);
            Console.WriteLine("Please select an option:\n");
            createOption("1", "Crack Onix Client");
            createOption("2", "Open Minecraft");
            createOption("3", "Onix Client Discord");
            createOption("4", "Exit");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                mainCrack(logo);
                Console.WriteLine("Cracking Onix Client...");
            }
            else if (input == "2")
            {
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Opening Minecraft...");
                Thread.Sleep(2000);
                OpenGame();
                goto startUP;
            }
            else if (input == "3")
            {
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Opening Discord...");
                Thread.Sleep(750);
                OpenURL("discord.gg/onixclient");
                goto startUP;
            }
            else if (input == "4")
            {
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Exiting...");
                Thread.Sleep(750);
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option!");
                Thread.Sleep(750);
                goto startUP;
            }

            static void mainCrack(string logo)
            {
                for (int i = 0; i < 20; i++)
                {

                    Console.WriteLine(logo, Color.Blue);
                    Console.Write("Downloading Onix Client.");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Download Complete!");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Preparing for install.");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(logo, Color.Blue);
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Installing Onix Client.");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(logo, Color.Blue);
                }
                Thread.Sleep(2000);
                Console.WriteLine("Installation Complete.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Launching Onix Client.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("!!IMPORTANT!!", Color.Red);
                Console.WriteLine("Before the game reaches the main menu, close the game.");
                Console.WriteLine("Then, open the game again.\n");
                Console.WriteLine("This is to ensure that the client is installed and cracked correctly.");
                Console.WriteLine("Failure to do this will result in your PC being blacklisted from using Onix Client PERMANENTLY!\n", Color.Red);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Launching Minecraft...");
                Thread.Sleep(3000);
                OpenGame();
                Thread.Sleep(6000);
                CloseGame();
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Failed to crack Onix Client!");
                Console.WriteLine("Key Expired!\n", Color.Red);
                Console.WriteLine("Purchase a new key at ");
                Console.Write("https://patreon.com/onixclient\n", Color.AliceBlue);
                Console.WriteLine("Opening patreon page.");
                OpenURL("https://patreon.com/onixclient");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Attempting Method 2");
                Console.WriteLine("Launching Minecraft...");
                Thread.Sleep(3000);
                OpenGame();
                Thread.Sleep(6000);
                CloseGame();
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Failed to crack Onix Client!");
                Console.WriteLine("Malformed Request!\n", Color.Red);
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Attempting Method 3");
                Console.WriteLine("Launching Minecraft...");
                Thread.Sleep(3000);
                OpenGame();
                Thread.Sleep(6000);
                CloseGame();
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Failed to crack Onix Client!");
                Console.WriteLine("Server denied access. Code 401.\n", Color.Red);
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Attempting Method 4");
                Console.WriteLine("Launching Minecraft...");
                Thread.Sleep(3000);
                OpenGame();
                Thread.Sleep(6000);
                CloseGame();
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Failed to crack Onix Client!");
                Console.WriteLine("Server sent valid response.\n", Color.Red);
                Thread.Sleep(2000);
                Console.WriteLine("Response: 200 OK");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Response: Maximum number of requests reached.");
                Thread.Sleep(2000);
                Console.WriteLine("IP Sent too many requests. Blacklisted.\n", Color.Red);
                Console.WriteLine("Tampering with the client is not allowed.");
                Console.WriteLine("Initiating \"Pirating Software Is Illegal\" procedure...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Stage 1: ");
                Console.Write("File Deletion", Color.Red);
                Thread.Sleep(2000);
                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(logo, Color.Blue);
                    Console.Write("Deleting files.");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Write(".");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine(logo, Color.Blue);
                }
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Stage 2: ");
                Console.WriteLine("cmljayByb2xsIHRpbWUhISEhISE=", Color.Red);
                Thread.Sleep(2000);
                OpenURL("https://shattereddisk.github.io/rickroll/rickroll.mp4");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Fuck you.");
                Thread.Sleep(500);
                Console.WriteLine("\nPay for software or get rickroll'd.");
                Thread.Sleep(10000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Purchase the patreon for $4.01 for actual access to the client.");
                OpenURL("https://patreon.com/onixclient");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("I hope you enjoyed your stay.");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                Console.WriteLine("Goodbye.");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine(logo, Color.Blue);
                var psi = new ProcessStartInfo("shutdown","/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }
    }
}