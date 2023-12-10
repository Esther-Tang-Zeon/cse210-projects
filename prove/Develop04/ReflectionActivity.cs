
// Guide the user to think deeply, by having them consider a
// certain experience when they were successful or demonstrated 
// strength. Then, prompt them with questions to reflect more
// deeply about details of this experience. They might discover 
// more depth than they previously realized.
class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        
        _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };

    }

    public void RunActivity()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt(_prompts);
        DisplayPrompt(prompt);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseCountdown5();
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);
            PauseSpinner();
            PauseSpinner();
            PauseSpinner();
            Console.WriteLine();
        }
        Console.WriteLine();
        EndMessage();
        Console.Clear();
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        return question;
    }

    public void DisplayQuestion(string question)
    {
        Console.Write($"> {question}");
    }

}