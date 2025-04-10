using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to store goals
            List<Goal> goals = new List<Goal>();

            // Displaying the menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Eternal Quest Goal Tracker!");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. View Goals");
                Console.WriteLine("3. Mark Goal as Completed");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddGoal(goals);
                        break;
                    case "2":
                        ViewGoals(goals);
                        break;
                    case "3":
                        MarkGoalCompleted(goals);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        // Method to add a new goal
        static void AddGoal(List<Goal> goals)
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the goal: ");
            string goalName = Console.ReadLine();
            Console.WriteLine("Enter a description for the goal: ");
            string description = Console.ReadLine();

            Goal newGoal = new Goal(goalName, description);
            goals.Add(newGoal);

            Console.WriteLine("Goal added successfully!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        // Method to view goals
        static void ViewGoals(List<Goal> goals)
        {
            Console.Clear();
            Console.WriteLine("Your Goals: ");
            if (goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
            }
            else
            {
                foreach (var goal in goals)
                {
                    Console.WriteLine($"- {goal.Name}: {goal.Description} (Completed: {goal.IsCompleted})");
                }
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        // Method to mark a goal as completed
        static void MarkGoalCompleted(List<Goal> goals)
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the goal to mark as completed: ");
            string goalName = Console.ReadLine();

            Goal goalToMark = goals.Find(goal => goal.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

            if (goalToMark != null)
            {
                goalToMark.MarkCompleted();
                Console.WriteLine($"Goal '{goalName}' marked as completed!");
            }
            else
            {
                Console.WriteLine($"Goal '{goalName}' not found.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    // Goal class to represent a goal
    class Goal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; private set; }

        public Goal(string name, string description)
        {
            Name = name;
            Description = description;
            IsCompleted = false;
        }

        // Method to mark the goal as completed
        public void MarkCompleted()
        {
            IsCompleted = true;
        }
    }
}
