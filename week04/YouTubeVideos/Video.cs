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

}