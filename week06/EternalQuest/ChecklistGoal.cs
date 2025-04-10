using System;

public class ChecklistGoal : Goal
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

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0; // No points if the goal is already completed
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public string GetDetailsString()
    {
        return $"{_shortName} - {_description}, Completed: {_amountCompleted}/{_target}, Points: {_points}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }
}
