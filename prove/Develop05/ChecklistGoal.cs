using System.Data.SqlTypes;
using System.IO.Compression;


public class ChecklistGoal : Goal
{
    // Target number of completion
    public int _completionGoal { get; private set; }
    // Current number of completions
    public int _currentCompleted { get; private set; }
    // Bonus points awarded upon reaching the completion goal
    public int _bonusPoints { get; private set; }

    // Constructor for ChecklistGoal
    public ChecklistGoal(string name, string description, int points, int completionGoal, int bonusPoints, int currentCompleted) : base(name, description, points)
    {
        _completionGoal = completionGoal;
        _currentCompleted = currentCompleted; 
        _bonusPoints = bonusPoints;
    }

    // Overrides RecordEvent from the base Goal class
    public override int RecordEvent()
    {
        // Increment current completion count
        _currentCompleted++; 
        if (_currentCompleted >= _completionGoal)
        {
            // Mark as complete if the target is reached
            _isComplete = true;
            // Return total points including bonus
            return _points + _bonusPoints;
        }
        // return standard points if target not reached
        return _points;
    }

    // Returns a string representation of the ChecklistGoal
    public override string ToString()
    {
        // Includes the base string representation and appends completion status
        return $"{base.ToString()} --- Currently Completed: {_currentCompleted}/{_completionGoal}";
    }
}