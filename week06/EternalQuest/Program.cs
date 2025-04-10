using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Goal Tracker");
            Console.WriteLine("1. List all goals");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Display player info");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.ListGoalNames();
                    break;
                case "2":
                    CreateNewGoal(goalManager);
                    break;
                case "3":
                    RecordGoalEvent(goalManager);
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("Create New Goal");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string goalType = Console.ReadLine();

        if (goalType == "3")
        {
            Console.Write("Enter target for checklist goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus for checklist goal: ");
            int bonus = int.Parse(Console.ReadLine());

            goalManager.CreateGoal("checklist", name, description, points, target, bonus);
        }
        else if (goalType == "2")
        {
            goalManager.CreateGoal("eternal", name, description, points);
        }
        else
        {
            goalManager.CreateGoal("simple", name, description, points);
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void RecordGoalEvent(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("Record Goal Event");
        Console.Write("Enter goal name to record: ");
        string goalName = Console.ReadLine();

        goalManager.RecordEvent(goalName);
        Console.WriteLine("Event recorded successfully!");
    }
}
