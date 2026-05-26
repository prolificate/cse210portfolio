using System;
using System.Collections.Generic;

//made the program choose scriptures randomly
//added a feature that chooses a scripture randomly 
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            )
        );

        scriptures.Add(
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            )
        );

        Random random = new Random();

        int index = random.Next(scriptures.Count);

        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}