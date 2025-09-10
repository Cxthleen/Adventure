using System;
using System.Threading;

class Menu
{
    public static void ShowMainMenu()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine(" ~  Starcrossed  ~ ");
            Console.WriteLine("================================\n");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Start new game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Load saved game");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose: ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Game.Start();
                    break;
                case "2":
                    ShowInstructions();
                    break;
                case "3":
                    Game.LoadGame();
                    break;
                case "4":
                    Console.Clear();    
                    Console.WriteLine("Bye Bye!");
                    Thread.Sleep(800);
                    running = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please enter 1-4.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    private static void ShowInstructions()
    {
        Console.Clear();
        Console.WriteLine("================== Instructions ==================");
        Console.WriteLine("Welcome to Starcrossed!");
        Console.WriteLine();
        Console.WriteLine("- Type the number of your choice and press Enter.");
        Console.WriteLine("- If you get stuck, type 'hint' to receive a suggestion.");
        Console.WriteLine("- Your choices affect the outcome of your story with Anakin.");
        Console.WriteLine("- You can save your progress and resume later.");
        Console.WriteLine("- Keep following your current goal at the top of the screen.");
        Console.WriteLine();
        Console.WriteLine("=================================================");
        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }
}
