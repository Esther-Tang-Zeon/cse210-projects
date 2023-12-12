using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        Video video1 = new Video("Monopoly", "Khan Sir", 100);
        Video video2 = new Video("Perfect Competition", "Tang Sir", 500);
        Video video3 = new Video("Monopolistic Competition", "Wong Sir", 700);

        // User interaction loop
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Choose a video to comment on:");
            Console.WriteLine("1. Monopoly");
            Console.WriteLine("2. Perfect Competition");
            Console.WriteLine("3. Monopolistic Competition");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddCommentToVideo(video1);
                    break;
                case "2":
                    AddCommentToVideo(video2);
                    break;
                case "3":
                    AddCommentToVideo(video3);
                    break;
                case "4":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void AddCommentToVideo(Video video)
    {
        Console.Write("Enter your comment: ");
        string commentText = Console.ReadLine();
        Console.Write("Enter your name: ");
        string commenterName = Console.ReadLine();

        Comment newComment = new Comment(commenterName, commentText);
        video.AddComment(newComment);

        Console.WriteLine("Comment added successfully!");
        video.DisplayVideoInfo();
    }
}