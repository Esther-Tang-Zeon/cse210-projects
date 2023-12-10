using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>
        {
            new Square("blue", 2),
            new Rectangle("green", 3, 5),
            new Circle("orange", 6)
        };

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


        



    }
}