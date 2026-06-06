using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();


        Video video1 = new Video("How to learn C# in 10 minutes", "TechAcademy", 600);
        video1.AddComment(new Comment("Juan", "This was very helpful, thanks!"));
        video1.AddComment(new Comment("Sarah", "Can you make a video about classes?"));
        video1.AddComment(new Comment("Mike", "Great explanation, straight to the point."));
        videosList.Add(video1);

        Video video2 = new Video("Funny Cat Compilation 2026", "CatLover99", 450);
        video2.AddComment(new Comment("Alice", "So cute!"));
        video2.AddComment(new Comment("Bob", "I can't stop laughing at the orange cat."));
        video2.AddComment(new Comment("Charlie", "Best video ever."));
        videosList.Add(video2);


        Video video3 = new Video("Easy Pasta Recipe", "Chef Mario", 300);
        video3.AddComment(new Comment("Elena", "Looks delicious, I'll try it tonight."));
        video3.AddComment(new Comment("David", "What kind of cheese did you use?"));
        video3.AddComment(new Comment("Sophia", "Very easy to follow, thanks Mario!"));
        videosList.Add(video3);


        Console.WriteLine("--- YouTube Video Tracker --- \n");
        foreach (Video video in videosList)
        {
            video.Display();
        }
    }
}