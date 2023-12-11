using System.IO.Compression;

// Class to manage different goals
public class ManageGoal 
{
    // List to store different goals
    private List<Goal> _goals;
    
    // Attribute to track total points earned
    public int _totalPoints { get; private set;}

    // Constructor for ManageGoal
    public ManageGoal()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    // Method to list all goals
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to list all goals
    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
         
    }

    // Method to only list the goal names (especially when the user wants to record the event)
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
        Console.WriteLine();
    }


    public int GoalsCount()
    {
        return _goals.Count;
    }

    public int _lastEarnedPoints { get; private set; }

    public void RecordGoalCompletion(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _lastEarnedPoints = _goals[goalIndex].RecordEvent();
            _totalPoints += _lastEarnedPoints;
            DisplayCongratulations();
            Console.WriteLine($"Congratulations! You have earned {_lastEarnedPoints} points!");
            Console.WriteLine($"You now have {_totalPoints} points.");
            Console.WriteLine();
        }
        else 
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    private void DisplayCongratulations()
    {
    // ASCII Art for a Trophy
    string happyTrophy = @"
                .-""""""-.
              .'          '.
             /   O      O   \
            :                :
            |                |   
            : ',          ,' :
             \  '-......-'  /
              '.          .'
                '-......-'

                ___________
               '._==_==_=_.'
               .-\:      /-.
              | (|:.     |) |
               '-|:.     |-'
                 \::.    /
                  '::. .'
                    ) (
                  _.' '._
                `""""""""""`

    ";

    Console.WriteLine(happyTrophy);
    }

    private void AnimateText(string text, int delay)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(delay); // Delay for animation effect
        }
        Console.WriteLine();
    }


    public void SaveGoals(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_totalPoints); // Save total points as the first line
            foreach (Goal goal in _goals)
            {
                string goalType = goal.GetType().Name;
                string goalData = $"{goalType}:{goal._name},{goal._description},{goal._points}";

                if (goal is ChecklistGoal checklistGoal)
                {
                    // Add specific data for ChecklistGoal
                    goalData += $",{checklistGoal._completionGoal},{checklistGoal._bonusPoints},{checklistGoal._currentCompleted}";
                }
                else if (goal is SimpleGoal)
                {
                    // Add isComplete status for SimpleGoal
                    goalData += $",{goal._isComplete}";
                }
                else if (goal is EternalGoal)
                {
                }
                
                file.WriteLine(goalData);
            }
        }
    }


    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _totalPoints = int.Parse(lines[0]);  // Assuming the first line is always total points.

        for (int i = 1; i < lines.Length; i++)  // Start from the second line
        {
            string[] parts = lines[i].Split(':');
            if (parts.Length < 2) continue; // Skip if the line format is not as expected

            string[] goalProps = parts[1].Split(',');
            string goalType = parts[0];

            // Make sure the array has enough elements
            if (goalProps.Length < 3) continue; 

            string name = goalProps[0];
            string description = goalProps[1];
            int points = int.Parse(goalProps[2]);

            Goal goal = null;
            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(goalProps[3]);
                    goal = new SimpleGoal(name, description, points, isComplete);
                    break;
                case "EternalGoal":
                    goal = new EternalGoal(name, description, points);
                    break;
                case "ChecklistGoal":
                    if (goalProps.Length < 6) continue; // Skip if not enough data for ChecklistGoal
                    int completionGoal = int.Parse(goalProps[3]);
                    int bonusPoints = int.Parse(goalProps[4]);
                    int currentCompleted = int.Parse(goalProps[5]);
                    goal = new ChecklistGoal(name, description, points, completionGoal, bonusPoints, currentCompleted);
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }




}