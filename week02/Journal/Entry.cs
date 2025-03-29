using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public Entry(string prompt, string response, string mood)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public Entry(string prompt, string response)
        : this(prompt, response, "Not specified") { }

    public override string ToString()
    {
        return $"[{Date}] {Prompt}\nMood: {Mood}\nResponse: {Response}\n";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length < 3) return null;

        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        string mood = parts.Length >= 4 ? parts[3] : "Not specified";

        return new Entry(prompt, response, mood) { Date = date };
    }
}
