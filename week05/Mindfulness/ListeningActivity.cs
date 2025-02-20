class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.") { }

    public void Run()
    {
        DisplayIntro();
        Console.WriteLine("\n" + Prompts[new Random().Next(Prompts.Count)]);
        ShowLoading(3);
        Console.WriteLine("Start listing items. Type one per line and press Enter. Type 'done' to finish.");
        var startTime = DateTime.Now;
        int count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
                break;
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayOutro();
    }
}