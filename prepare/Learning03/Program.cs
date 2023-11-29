using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Using the no-argument constructor
        Fraction f1 = new Fraction();
        Console.WriteLine($"{f1.GetFractionString()}\n{f1.GetDecimalValue()}");

        // Using the constructor with one argument
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"{f2.GetFractionString()}\n{f2.GetDecimalValue()}");

        // Using the constructor with two arguments
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"{f3.GetFractionString()}\n{f3.GetDecimalValue()}");

        // Using the constructor with two arguments 
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"{f4.GetFractionString()}\n{f4.GetDecimalValue()}");
        
    }

}