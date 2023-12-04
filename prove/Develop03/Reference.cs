//This class stores the book, chapter, and verse information.
//It has 2 constructors to handle single verses and verse ranges.
public class Reference 
{
    // Fields to store the book name, chapter, and verses
    private string _book; // Name of the book in the scripture
    private int _chapter; // Chapter number in the scripture
    private int _startVerse; // Starting verse number
    private int? _endVerse; // Ending verse number (Nullable for single verse references)

    // Constructor for  single verse reference
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null; // No end verse for a single verse
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the scripture reference as a formatted string
    public string GetReference()
    {
        // Formats and returns the scripture reference
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" : $"{_book} {_chapter}:{_startVerse}";
    }

}