using System.Security.Principal;

// Abstract base class for different types of goals
public abstract class Goal 
{
    // Attributes of the goal
    public string _name { get; protected set; }
    public string _description { get; protected set; }
    public int _points { get; protected set; }
    public bool _isComplete { get; set; }
    
    // Constructor for the Goal class
    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Abstract method to record event completion, to be overridden in derived classes
    public abstract int RecordEvent();

    // Method to return a string representation of the goal
    public override string ToString() 
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name} ({_description})";

    }

}