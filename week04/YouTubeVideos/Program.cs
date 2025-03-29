using System;
using System.Collections.Generic;

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
