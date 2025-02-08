using System;

class Program
{
    static void Main(string[] args)
    {
        if (File.Exists("scriptures.txt"))
        {
            string[] scriptures = File.ReadAllLines("scriptures.txt");

            Random random = new Random();
            int randomScriptureIndex = random.Next(scriptures.Length);
            string randomScripture = scriptures[randomScriptureIndex];
            string [] sections = randomScripture.Split(" | ");
            string scriptureReference = sections[0];
            string scriptureText = sections[1];

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