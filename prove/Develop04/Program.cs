using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool continueRunning = true;
        while (continueRunning)
        {
            // Display menu options
            Console.WriteLine($"Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            // Safe parsing of user choice
            if (int.TryParse(Console.ReadLine(), out int userChoice)) 
            {
                switch (userChoice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                        breathingActivity.RunActivity();
                        break;
                    
                    case 2:
                        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        reflectionActivity.RunActivity();
                        break;

                    case 3:
                        ListingActivity listingActivity = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        listingActivity.RunActivity();
                        break;

                    case 4:
                        continueRunning = false; // Break the loop to exit the program 
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option selected. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
                Console.WriteLine();
            }
        }
    }
}