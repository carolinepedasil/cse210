using System;

// Exceeding requirements:
// - Added session counters for each activity
// - Ensured prompts/questions do not repeat until all are used
// - Added a new "Visualization Activity" to guide peaceful mental imagery

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int visualizationCount = 0;

        while (choice != 5)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Visualization Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Thread.Sleep(1500);
                continue;
            }

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    breathingCount++;
                    break;
                case 2:
                    new ReflectionActivity().Run();
                    reflectionCount++;
                    break;
                case 3:
                    new ListingActivity().Run();
                    listingCount++;
                    break;
                case 4:
                    new VisualizationActivity().Run();
                    visualizationCount++;
                    break;
                case 5:
                    Console.WriteLine("\nThanks for being mindful!");
                    Console.WriteLine($"Breathing sessions: {breathingCount}");
                    Console.WriteLine($"Reflection sessions: {reflectionCount}");
                    Console.WriteLine($"Listing sessions: {listingCount}");
                    Console.WriteLine($"Visualization sessions: {visualizationCount}");
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
