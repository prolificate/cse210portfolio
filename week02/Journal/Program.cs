using System;

//added extra information to it
//added extra information for the journal entry
class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();

       PromptGenerator promptGenerator = new PromptGenerator();
       bool running = true;
       while (running)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                //extra entry added
                Console.WriteLine($"How are you feeling today?");
                string mood = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Propmpt: {prompt}");
                Console.Write(">");
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;
                entry._mood = mood;
                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }

            else if(choice == "2")
            {
                journal.DisplayAll();
            }

            else if(choice == "3")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.SavaeToFile(fileName);
            }

            else if(choice == "4")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }

            
            else if(choice == "5")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
            
        }
    }
}