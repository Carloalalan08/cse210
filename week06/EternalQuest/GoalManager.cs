using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Start the goal tracking system here
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(string goalType, string name, string description, int points, int target = 0, int bonus = 0)
    {
        Goal newGoal = goalType.ToLower() switch
        {
            "simple" => new SimpleGoal(name, description, points),
            "eternal" => new EternalGoal(name, description, points),
            "checklist" => new ChecklistGoal(name, description, points, target, bonus),
            _ => throw new ArgumentException("Invalid goal type")
        };
        _goals.Add(newGoal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.Find(g => g.GetStringRepresentation().Contains(goalName));
        if (goal != null)
        {
            _score += goal.RecordEvent();
        }
    }

    public void SaveGoals()
    {
        // Implement logic to save goals to a file
    }

    public void LoadGoals()
    {
        // Implement logic to load goals from a file
    }
}
