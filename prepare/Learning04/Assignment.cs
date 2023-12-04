using System.Xml.Serialization;

// The Assignment class serves as a base class for different types of assignments.
// It holds common properties like student's name and topic 
public class Assignment 
{
    protected string _studentName = "";
    protected string _topic = "";

    // Constructor to initialize the Assignment class with student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters and setters for student name and topic
    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // Method to get the summary of the assignment
    public string GetSummary()
    {
        // Return the summary as a string
        return $"{_studentName} - {_topic}";
    }



}