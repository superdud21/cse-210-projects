using System;


// In an attempt to be creative, I also prompt for mood and energy levels to track and display for the user. 
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        Prompts prompt = new Prompts();

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
                    string entryPrompt = prompt.GetPrompt();

                    Console.WriteLine("Before we begin, lets track a few things:");
                    Console.WriteLine("Enter your mood (1-10): ");
                    string mood = Console.ReadLine();
                    Console.WriteLine("Enter your energy levels (1-10): ");
                    string energy = Console.ReadLine();
                    Console.WriteLine($"Prompt: {entryPrompt}");
                    Console.WriteLine($"Write your entry here: ");
                    
                    string newEntry = Console.ReadLine();
                    journal.AddEntry(date: DateTime.Now.ToString(), mood, energy, entryPrompt, newEntry); 
                    break;

                case "2":
                   
                    journal.DisplayAll();

                    break;

                case "3":

                    journal.LoadFromFile();

                    break;

                case "4":

                    journal.SaveToFile();

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