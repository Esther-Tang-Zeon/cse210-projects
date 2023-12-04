using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        // Call GetSummary and display the result
        string summary1 = assignment1.GetSummary();
        Console.WriteLine(summary1);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 9-8");
        string mathSummary1 = mathAssignment.GetSummary();
        string mathSummary2 = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathSummary1);
        Console.WriteLine(mathSummary2);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string writingSummary1 = writingAssignment.GetSummary();
        string writingSummary2 = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingSummary1);
        Console.WriteLine(writingSummary2);

    }
}