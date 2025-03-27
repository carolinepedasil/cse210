using System;

class Program
{
    static void Main(string[] args)
    {
        // I exceeded the core requirements by:
        // - Preventing already hidden words from being chosen again (better user experience).

        Reference reference = new Reference("Enos", 1, 15);
        string text = "Wherefore, I knowing that the Lord was able to preserve our records, I cried unto him continually, for he had said unto me: Whatsoever thing ye shall ask in faith, believing that ye shall receive in the name of Christ, ye shall receive it.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }
        }
    }
}
