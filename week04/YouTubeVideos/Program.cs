using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# Basics", "Code Academy", 600);
        Video video2 = new Video("OOP Explained", "Tech World", 720);
        Video video3 = new Video("Abstraction in C#", "BYU-I Tutor", 540);

        // Add comments to video 1
        video1.AddComment(new Comment("Jose", "Very helpful video!"));
        video1.AddComment(new Comment("Maria", "I finally understand classes."));
        video1.AddComment(new Comment("Luis", "Great explanation."));

        // Add comments to video 2
        video2.AddComment(new Comment("Ana", "This cleared my doubts."));
        video2.AddComment(new Comment("Carlos", "Nice examples."));
        video2.AddComment(new Comment("Elena", "Well explained."));

        // Add comments to video 3
        video3.AddComment(new Comment("Pedro", "Perfect for beginners."));
        video3.AddComment(new Comment("Sofia", "Thanks for this lesson."));
        video3.AddComment(new Comment("Miguel", "Very clear explanation."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video info
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
