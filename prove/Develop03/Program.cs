using System;

class Program
{
    static void Main(string[] args)
    {   
        // Initialize a new library of scriptures
        ScriptureLibrary library = new ScriptureLibrary();
        // Display the list of available scriptures to the console
        library.DisplayScriptures(); 

        Console.Write("Select a scripture by number: ");
        // Read the user's choice and convert it to an integer, then subtract 1 for zero-based indexing
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        // Retrieve the chosen scripture from the library
        Scripture chosenScripture = library.GetScripture(choice);

        // Check if a valid scripture was selected
        if (chosenScripture != null)
        {
            // Keep running the loop until all words in the scripture are hidden
            while (!chosenScripture.IsCompletelyHidden())
            {
                // Clear the console for fresh display
                Console.Clear();
                // Display the current state of the scripture (with some words hidden)
                chosenScripture.Display();
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                // Read the user's input
                string input = Console.ReadLine();
                // Exit the loop if the user types 'quit'
                if (input.ToLower() == "quit") break;

                // Hide a random number of words in the scripture
                chosenScripture.HideWords(); 
            }
            // Display a congratulatory message when the scripture is fully memorized
            Console.WriteLine("Congratz! Scripture fully memorized. :)");
        }
        else
        {
            // Display an error message for invalid selection
            Console.WriteLine("Invalid selection.");
        }
    }
}