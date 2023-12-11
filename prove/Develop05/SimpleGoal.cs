using System.Drawing;

// Class for simple goals, derived from Goal
public class SimpleGoal : Goal
{
    // Constructor for SimpleGoal
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Method to record event completion
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

}