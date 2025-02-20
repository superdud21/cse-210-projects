class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int totalPoints = _points;
            if (_amountCompleted == _target)
            {
                totalPoints += _bonus;
                Console.WriteLine($"Goal '{_shortName}' fully completed! Bonus {_bonus} points awarded.");
            }
            Console.WriteLine($"Progress recorded for '{_shortName}'. Earned {totalPoints} points.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {_shortName} ({_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }
}