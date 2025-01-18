using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write Journal Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":

                    break;

                case "2":
                   
                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    running = false;
                    break;

                default:
                
                    break;
            }
        }
    }
}