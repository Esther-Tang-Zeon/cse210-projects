
// Help the user pace their breathing to have a session of 
// deep breathing for a certain amount of time. They might 
// find more peace and less stress through the exercise.
using System.Diagnostics;

class BreathingActivity : Activity
{
    // Inherits from Activity and uses its constructor
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    
    public void RunActivity()
    {
        StartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            PerformBreathing("Inhale ", 15, 1000); // Inhale animation
            PerformBreathing("Exhale ", 15, 2500); // Exhale animation
            // Console.Write($"Breathe in...");
            // PauseCountdown3();
            // Console.WriteLine();
            // Console.Write($"Now breathe out...");
            // PauseCountdown5();
            // Console.WriteLine();
            // Console.WriteLine();

        }
        EndMessage();
        Console.Clear();
    }

    public void PerformBreathing(string actionText, int expansionRange, int cycleDuration)
    {
       // Expanding animation 
       for (int i = 0; i <= expansionRange; i++)
       {
            Console.Clear();
            Console.WriteLine(GenerateBreathingText(actionText, i));
            Thread.Sleep(cycleDuration / (expansionRange * 2));
        }
        
        // Contracting animation
        for (int i = expansionRange; i >= 0; i--)
       {
            Console.Clear();
            Console.WriteLine(GenerateBreathingText(actionText, i));
            Thread.Sleep(cycleDuration / (expansionRange * 2));
        }
    }  

    private string GenerateBreathingText(string baseText, int padding)
    {
    // Creates a visual effect using special characters
    string visualEffect = new string('*', padding);
    return $"{baseText}{visualEffect}> ";
    }
}