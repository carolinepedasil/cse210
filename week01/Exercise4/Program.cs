using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number;

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            if (number == 0)
                break;

            numbers.Add(number);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

        int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
