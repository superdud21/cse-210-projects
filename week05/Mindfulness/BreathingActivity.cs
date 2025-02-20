class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breath.") { }

    public void Run()
    {
        DisplayIntro();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowLoading(3);
            Console.WriteLine("Breathe out...");
            ShowLoading(3);
        }
        DisplayOutro();
    }
}
