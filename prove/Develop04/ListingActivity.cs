// Guide the user to think broadly, by helping them list as many
// things as they can in a certain area of strength or positivity. 
// They might discover more breadth than they previously realized.
class ListingActivity : Activity
{
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunActivity()
    {
        StartMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string prompt = GetRandomPrompt(_prompts);
        DisplayPrompt(prompt);
        Console.Write("You may begin in: ");
        PauseCountdown5();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userResponses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string userResponse = Console.ReadLine();
            userResponses.Add(userResponse);
        }
        Console.WriteLine($"You listed {userResponses.Count} items!");
        Console.WriteLine();
        EndMessage();
        Console.Clear();

    }




}