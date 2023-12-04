using System.ComponentModel;

// The MathAssignment class inherits from the Assignment class.
// It includes specific properties for math assignments, like textbook section and problems.
public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";

    // Constructor for MathAssignment class, initializing base and specific properties
    public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    // Getters and setters for textbook section and problem
    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    // Method to get the detailed homework list for math assignments
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problem}";
    }
}