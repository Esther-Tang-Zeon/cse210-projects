using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Activity
{
    public string _name = "";
    public string _description = "";
    public int _duration;

    // Constructor initializes common properties
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    // Displays the starting message
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\nThis activity will help you {_description}.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseSpinner();
        Console.WriteLine();

    }

    // Displays the ending message
    public void EndMessage()
    {
        Console.WriteLine($"Well Done!!");
        PauseSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        PauseSpinner();
    }

    // Utility method for a simple animation
    public void PauseSpinner()
    {
        List<string> spinnerStrings = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-" 
        };

        foreach (string s in spinnerStrings)
        {
            Console.Write(s);
            Thread.Sleep(350);
            Console.Write("\b \b");
        }

    }

    public void PauseCountdown3()
    {
        for (int i = 3; i > 0; i--)
        {       
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseCountdown5()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public string GetRandomPrompt(List<string> prompts)
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($" --- {prompt} ---");
    }


}