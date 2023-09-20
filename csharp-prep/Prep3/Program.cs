using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,101);
        Console.WriteLine($"What is the magic number? {randomNumber}");
        int guess;

        do
        {
        Console.Write("What is your guess? ");
        string response = Console.ReadLine();
        guess = int.Parse(response);
        
        if (guess > randomNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < randomNumber)
        {
            Console.WriteLine("Higher");
        }
        else 
        {
            Console.WriteLine("You guessed it!");
        }
        } while (guess != randomNumber);
    }
}