class Video
{
    private string _name;
    private double _videoDuration;
    private List<Comment> _comments;

    public Video(string name, double duration)
    {
        _name = name;
        _videoDuration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string DisplayAllComments()
    {
        string output = "Comments:\n";
        foreach (var comment in _comments)
        {
            output += comment.GetCommentInfo() + "\n";
        }
        return output;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Duration: {_videoDuration} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine(DisplayAllComments());
        Console.WriteLine("\n----------------------\n");
    }
}