class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    private const string FilePath = "goals.txt";

    public void Start()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("\nMenu:\n1) Create Goal\n2) List Goals\n3) Record Event\n4) Save\n5) Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": SaveGoals(); return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        DisplayPlayerInfo();
    }

    public void ListGoalDetails()
    {
        ListGoalNames();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1) Simple \n2) Eternal \n3) Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = choice switch
        {
            "1" => new SimpleGoal(name, description, points),
            "2" => new EternalGoal(name, description, points),
            "3" => CreateChecklistGoal(name, description, points),
            _ => throw new Exception("Invalid choice"),
        };

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter target count: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, description, points, target, bonus);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        using StreamWriter writer = new(FilePath);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        if (!File.Exists(FilePath))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using StreamReader reader = new(FilePath);
        _score = int.Parse(reader.ReadLine());
        _goals.Clear();

        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            Goal goal = parts[0] switch
            {
                "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])),
                "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])),
                _ => throw new Exception("Invalid goal type"),
            };
            _goals.Add(goal);
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}