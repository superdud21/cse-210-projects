using System;

public class Prompts
{
    public List<string> _prompts;
    string promptsFile = "prompts.txt";

    public string GetPrompt()
    {

        if (File.Exists(promptsFile))
        {
            _prompts = File.ReadAllLines(promptsFile).ToList();
        } else {
            Console.WriteLine("No Prompts File Exists.");
        }


        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
}