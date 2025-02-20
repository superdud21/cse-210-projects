class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"\n{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowLoading(3);
    }

    public void DisplayOutro()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowLoading(3);
    }

    public void ShowLoading(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}