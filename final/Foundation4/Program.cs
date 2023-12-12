using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store different activities
        List<Activity> activities = new List<Activity>();

        // Create a running activity and add it to the list
        DateTime runningDate = new DateTime(2023, 12, 25);
        int runningDuration = 50; // Duration in minutes
        double runningDistance = 10.0; // Distance in km
        Running runningActivity = new Running(runningDate, runningDuration, runningDistance);
        activities.Add(runningActivity);

        // Create a cycling activity and add it to the list
        DateTime cyclingDate = new DateTime(2023, 12, 26);
        int cyclingDuration = 55; // Duration in minutes
        double cyclingSpeed = 30; // Speed in km per hour
        Cycling cyclingActivity = new Cycling(cyclingDate, cyclingDuration, cyclingSpeed);
        activities.Add(cyclingActivity);

        // Create a swimming activity and add it to the list
        DateTime swimmingDate = new DateTime(2023, 12, 27);
        int swimmingDuration = 60; // Duration in minutes
        int swimmingLaps = 10; // Number of laps
        Swimming swimmingActivity = new Swimming(swimmingDate, swimmingDuration, swimmingLaps);
        activities.Add(swimmingActivity);

        // Iterating over each activity to print its summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}