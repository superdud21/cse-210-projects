using System;

class Program
{
    static void Main(string[] args)
    {
        if (File.Exists("scriptures.txt"))
        {
            string[] scriptures = File.ReadAllLines("scriptures.txt");

            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    break;
                }
            }
        } else {
            Console.WriteLine("No Scripture File Exists");
        }
    }
}