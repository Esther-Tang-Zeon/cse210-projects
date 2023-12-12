public class Video 
{
    public string _title { get; private set; }
    public string _author { get; private set; }
    public int _length { get; private set; } // Length of the video in seconds
    private List<Comment> _comments = new List<Comment>(); // List to store comments

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to add a comment
    public void AddComment(Comment textComment)
    {
        _comments.Add(textComment);
    }

    // Method to get the number of comments
    public int GetNumberComments()
    {
        return _comments.Count();
    }

    // Method to display video details 
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length of the video: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberComments()}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($" - {comment._textComment} by {comment._personName}");
        }
    }
}