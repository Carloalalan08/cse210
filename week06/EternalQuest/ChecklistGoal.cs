class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You completed {_amountCompleted} out of {_target}. You earned {_points} points.");
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus earned! You completed the goal and earned an additional {_bonus} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() => $"[ ] {_name}: {_description} Completed {_amountCompleted}/{_target} times";

    public override string GetStringRepresentation() => $"{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
}
