using System;
using System.Collections.Generic;


class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static Dictionary<string, List<string>> categorizedPrompts = new Dictionary<string, List<string>>
    {
        {"Self-reflection", new List<string> { "How do I feel today?", "What did I learn about myself?" }},
        {"Future goals", new List<string> { "Where do I see myself in 5 years?", "What's a goal I want to achieve next month?" }},
        {"Past experiences", new List<string> { "What's a childhood memory that stands out?", "Describe a past event that changed your life." }},
        {"Dreams", new List<string> { "Describe a recent dream you had.", "What's a recurring dream theme for you?" }}
    };

    static void Main(string[] args)
    {
        JournalCollection journal = new JournalCollection();
        bool keepRunning = true;

        // Display the main menu to allow the user to make a choice. 
        // Store prompts and select one randomly when the user wants to write a new entry. 
        // Read/Write the file 

        Console.WriteLine("Welcome to the Journal Program!");

        while (keepRunning)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            // Write a new entry
            if (choice == 1)
            {
                Console.WriteLine("Please select a category:");
                int index = 1;
                foreach (var category in categorizedPrompts.Keys)
                {
                    Console.WriteLine($"{index}. {category}");
                    index++;
                }

                int categoryChoice;
                if (!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > categorizedPrompts.Count)
                {
                    Console.WriteLine("Invalid category choice. Please select a valid option.");
                    continue;
                }

                string selectedCategory = new List<string>(categorizedPrompts.Keys)[categoryChoice - 1];
                Random rand = new Random();
                int promptIndex = rand.Next(categorizedPrompts[selectedCategory].Count);
                Console.WriteLine(categorizedPrompts[selectedCategory][promptIndex]);

                string response = Console.ReadLine();
                JournalEntry newEntry = new JournalEntry(categorizedPrompts[selectedCategory][promptIndex], response);
                journal.AddEntry(newEntry);
            }

            // Display the journal
            else if (choice == 2)
            {
                journal.Display();
            }

            // Load the journal from a file
            else if (choice == 3)
            {
                Console.Write("Enter filename to load: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }

            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to save to:");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }

            else if (choice == 5) 
            {
                keepRunning = false;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }


        }
    }
}