class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress for '{_shortName}'. Earned {_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString() => "[∞] " + _shortName;

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}