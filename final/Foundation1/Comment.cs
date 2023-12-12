public class Comment 
{
    public string _personName { get; private set; }
    public string _textComment { get; private set; }

    public Comment(string personName, string textComment) 
    {
        _personName = personName;
        _textComment = textComment;
    }
}