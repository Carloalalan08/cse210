using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity helps you reflect on positive aspects of your life.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        
        Random random = new Random();
        Console.WriteLine("\n" + prompts[random.Next(prompts.Length)]);
        Console.WriteLine("You have a few seconds to think...");

        PauseWithAnimation(5);
        Console.WriteLine("\nStart listing:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndActivity();
    }
}
