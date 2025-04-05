using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public override void Run()
    {
        StartMessage();
        Random rand = new Random();

        string prompt = _prompts.OrderBy(x => rand.Next()).First();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($">>> {prompt}");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder each of the following questions as they relate to this experience:");
        List<string> shuffled = _questions.OrderBy(x => rand.Next()).ToList();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        foreach (string question in shuffled)
        {
            if (DateTime.Now >= endTime) break;
            Console.Write($"> {question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        EndMessage();
    }
}
