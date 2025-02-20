using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", 600);
        video1.AddComment(new Comment("Nephi", "Great explanation!"));
        video1.AddComment(new Comment("Lamen", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Lemuel", "Can you make more videos on this?"));

        Video video2 = new Video("Object-Oriented Programming", 900);
        video2.AddComment(new Comment("Job", "OOP is so important!"));
        video2.AddComment(new Comment("Eve", "Nice breakdown of concepts."));
        video2.AddComment(new Comment("Adam", "I finally understand this, thank you!"));

        Video video3 = new Video("Advanced C#", 1200);
        video3.AddComment(new Comment("Abraham", "Really advanced stuff, I love it!"));
        video3.AddComment(new Comment("Matthew", "Took me a while, but I got it!"));
        video3.AddComment(new Comment("Luke", "Subscribed! Waiting for more."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}