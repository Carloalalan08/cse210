using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class PromptGenerator
{
    private static List<string> prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What is something you learned today?",
        "Describe a moment you felt grateful for today.",
        "What challenge did you face today and how did you handle it?",
        "What are your goals for tomorrow?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        string filename = "journal.txt";
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Program");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile(filename);
                    break;
                case "4":
                    journal.LoadFromFile(filename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
