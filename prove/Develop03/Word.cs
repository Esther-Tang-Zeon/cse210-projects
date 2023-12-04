// This class represents an individual word in a scripture. It can be hidden or shown. 
public class Word 
{
    // Field to store the text of the word and its hidden state
    private string _text; // The actual text of the word
    private bool _isHidden; // Indicates whether the word is hidden or visible

    // Constructor to initialize the word with given text
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are initaially visible
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to get the display text of the word, or underscores if the word is hidden
    public string GetRenderedText()
    {
        // If the word is hidden, return "____" otherwise, return the word itself
        return _isHidden ? "____" : _text;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        // Return the hidden state of the word 
        return _isHidden;
    }
}
    