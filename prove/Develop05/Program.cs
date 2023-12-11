using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Initialize goal manager
        ManageGoal manager = new ManageGoal();
        // Store the last used filename for saving/loading
        string lastUsedFilename = "";
        // Variable to store user's menu choice 
        int userChoice;

        // Start of the main loop
        do 
        {
            Console.WriteLine($"You have {manager._totalPoints} points.");
            Console.WriteLine();
            // Display menu options
            Console.WriteLine(@"Menu Options:
            1. Create New Goal
            2. List Goal
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit");

            // Prompt user to choose an option
            Console.Write("Select a choice from the menu: ");
            // Read and parse user input
            userChoice = int.Parse(Console.ReadLine());

            // Handle user choice using a switch statement
            switch (userChoice)
            {
                // Create a new goal
                case 1:
                    CreateNewGoal(manager);
                    break;

                // List all goals
                case 2:
                    Console.WriteLine("The goals are: ");
                    manager.ListGoals();
                    break;
                
                // Save goals to a file
                case 3:
                   Console.Write("What is the filename for the goal file? ");
                    string saveFilename = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(saveFilename) && !string.IsNullOrWhiteSpace(lastUsedFilename))
                    {
                        saveFilename = lastUsedFilename;
                    }

                    if (!string.IsNullOrWhiteSpace(saveFilename))
                    {
                        manager.SaveGoals(saveFilename);
                        lastUsedFilename = saveFilename;
                        Console.WriteLine($"Goals saved successfully to {saveFilename}.");
                    }
                    else
                    {
                        Console.WriteLine("No filename provided. Goals not saved.");
                    }
                    break;

                // Load goals from a file
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(loadFilename) && !string.IsNullOrWhiteSpace(lastUsedFilename))
                    {
                        loadFilename = lastUsedFilename;
                    }

                    if (!string.IsNullOrWhiteSpace(loadFilename))
                    {
                        try
                        {
                            manager.LoadGoals(loadFilename);
                            lastUsedFilename = loadFilename;
                            Console.WriteLine($"Goals loaded successfully from {loadFilename}.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error loading goals: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No filename provided. Goals not loaded.");
                    }
                    break;

                // Record completion of a goal
                case 5:
                    if (manager.GoalsCount() == 0)
                    {
                        Console.WriteLine("No goals available to record.");
                        break;
                    }

                    Console.WriteLine("The goals are:");
                    manager.ListGoalNames();
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1; // Subtract 1 for zero-based index

                    if (goalIndex >= 0 && goalIndex < manager.GoalsCount())
                    {
                        manager.RecordGoalCompletion(goalIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    break;

                // Quit the program
                case 6:
                    Console.WriteLine("Quitting program.");
                    break;

                // Handle invalid choices
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            } 
        } while (userChoice != 6); // Continue until the user chooses to quit
    }

    // Method to create a new goal
    static void CreateNewGoal(ManageGoal manager)
    {
        Console.WriteLine(@"The types of Goals are:
        1. Simple Goal
        2. Eternal Goal 
        3. Checklist Goal");
        Console.Write($"Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write($"What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write($"What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(goalName, goalDescription, points);
                break;

            case 2:
                goal = new EternalGoal(goalName, goalDescription, points);
                break;
                
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int completionGoal = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(goalName, goalDescription, points, completionGoal, bonusPoints, 0);
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        if (goal != null)
        {
            manager.AddGoal(goal);
            Console.WriteLine("Goal added successfully.");
        }
    }
}
