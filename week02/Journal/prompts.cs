using System;

public class Prompts
{
    public List<string> _prompts;
    string promptsFile = "prompts.txt";

    public string GetPrompt()
    {
        
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
}