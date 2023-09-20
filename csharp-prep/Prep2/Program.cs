using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else 
        {
            Console.WriteLine("You did not pass the class. Try harder next time! ");
        }





    }
}