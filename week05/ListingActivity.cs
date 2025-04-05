using System;
using System.Collections.Generic;
using System.Linq;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        StartMessage();
        Random rand = new Random();

        string prompt = _prompts.OrderBy(x => rand.Next()).First();
        Console.WriteLine($"\nList responses to the following prompt:\n>>> {prompt}");
        Console.WriteLine("You will have a few seconds to think...");
        Countdown(5);
        Console.WriteLine("Start listing now:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                items.Add(entry);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        EndMessage();
    }
}
