using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage;

        if (!int.TryParse(input, out gradePercentage))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        string letter;
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
            if (gradePercentage <= 92)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = gradePercentage % 10;
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll do better next time.");
        }
    }
}
