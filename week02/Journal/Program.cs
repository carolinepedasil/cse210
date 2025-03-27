using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"[{Date}] {Prompt}\nResponse: {Response}\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3) return null;
        return new Entry(parts[1], parts[2]) { Date = parts[0] };
    }
}

class Journal
{
    private List<Entry> _entries;
    private static readonly List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        _entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry saved!");
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            Entry entry = Entry.FromFileFormat(line);
            if (entry != null)
            {
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded successfully!");
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
