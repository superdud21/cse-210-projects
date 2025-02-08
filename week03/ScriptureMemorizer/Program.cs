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

            string[] referenceParts = scriptureReference.Split(' '); 
            string book = referenceParts[0];
            string[] chapterVerseParts = referenceParts[1].Split(':');
            int chapter = int.Parse(chapterVerseParts[0]);
            int verse, endVerse;

            Reference reference;
            if (chapterVerseParts[1].Contains("-"))
            {
                string[] verseParts = chapterVerseParts[1].Split('-');
                verse = int.Parse(verseParts[0]);
                endVerse = int.Parse(verseParts[1]);
                reference = new Reference(book, chapter, verse, endVerse);
            }
            else
            {
                verse = int.Parse(chapterVerseParts[1]);
                reference = new Reference(book, chapter, verse);
            }

            Scripture scripture = new Scripture(reference, scriptureText);
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    break;
                }
                scripture.HideWords();

                Console.Clear();

                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden. Program has ended.");
                    break;
                }
            }
        } else {
            Console.WriteLine("No Scripture File Exists");
        }
    }
}