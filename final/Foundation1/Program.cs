using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Monopoly", "Khan Sir", 100);
        Video video2 = new Video("Perfect Competition", "Tang Sir", 500);
        Video video3 = new Video("Monopolistic Competition", "Wong Sir", 700);

        Comment comment1 = new Comment("tang1", "Nice video!");
        Comment comment2 = new Comment("tang2", "Awesome video!");
        Comment comment3 = new Comment("tang3", "Cool video!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);

        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);

        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
    }
}