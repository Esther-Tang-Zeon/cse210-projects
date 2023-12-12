using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating different types of events with specific details
        Lecture lectureEvent = new Lecture("Musicianship 1", "Music theory and singing techniques", new DateTime(2023, 12, 25), "4 PM", new Address("667 S 2nd E", "Rexburg", "ID", "USA"), "Dr. Thomas", 100);
        Reception receptionEvent = new Reception("Wedding Reception", "Attending best friend's wedding", new DateTime(2023, 12, 26), "5 PM", new Address("342 River", "Ogden", "UT", "USA"), "wedding@gmail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Rock Climbing", "Outdoor Climbing Competition 2023", new DateTime(2023, 12, 27), "6 PM", new Address("83 Street", "Sacramento", "CA", "USA"), "Sunny day");

        // Displaying details for each event
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}