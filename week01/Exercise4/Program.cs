// Mon Carlo R. Alalan
// CSE210 Team 02 - Wednesdays 16:00 (UTC-0)
// C# Programming Exercise 4—Lists

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Collect user inputs
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)  // Don't add 0 to the list
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Calculate sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Calculate average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge - Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Stretch Challenge - Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
