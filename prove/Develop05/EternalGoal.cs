using System.Security.Cryptography.X509Certificates;

public class EternalGoal : Goal
{
    // Constructor for EternalGoal
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // Inherits from the base Goal class constructor
    }

    // Overrides RecordEvent from the base Goal class
    public override int RecordEvent()
    {
        // Returns the points for the eternal goal
        return _points;
    }


}