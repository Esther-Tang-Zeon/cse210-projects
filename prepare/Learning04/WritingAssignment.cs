// The WritingAssignment class, derived from Assignment, caters to writing assignments.
// It includes additional properties like the title of the writing assignment.
public class WritingAssignment : Assignment
{
    private string _title = "";

    // Constructor for WritingAssignment, initializing base and specific properties
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title =  title;
    }
    
    // Getters and setters for title 
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    // Method to get writing information, including title and student details
    public string GetWritingInformation()
    {
        return $"{_title}";
    }



}