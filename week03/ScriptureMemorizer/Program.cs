// Mon Carlo R. Alalan
// CSE 210 Team 02 - Wednesdays 16:00 (UTC-0)
// W03 Project: Scripture Memorizer Program

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = LoadScriptures();
        Scripture scripture = scriptures[new Random().Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            scripture.HideRandomWords(2);
        }
    }

    static List<Scripture> LoadScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 2)
            {
                Reference reference = new Reference(parts[0]);
                scriptures.Add(new Scripture(reference, parts[1]));
            }
        }
        return scriptures;
    }
}
