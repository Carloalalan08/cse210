using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments ({GetCommentCount()}):");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("How to Cook Pasta", "Chef Gordon", 300),
            new Video("DIY Home Decor", "Creative Minds", 450),
            new Video("Top 10 Travel Destinations", "GlobeTrotter", 600)
        };

        videos[0].AddComment(new Comment("Alice", "Great tutorial!"));
        videos[0].AddComment(new Comment("Bob", "Very helpful, thanks!"));
        videos[0].AddComment(new Comment("Charlie", "Love the recipe!"));

        videos[1].AddComment(new Comment("David", "Amazing ideas!"));
        videos[1].AddComment(new Comment("Eve", "I’m trying this out!"));
        videos[1].AddComment(new Comment("Frank", "Beautiful designs."));

        videos[2].AddComment(new Comment("Grace", "Adding these to my bucket list!"));
        videos[2].AddComment(new Comment("Heidi", "Great recommendations!"));
        videos[2].AddComment(new Comment("Ivan", "I want to visit them all!"));

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
