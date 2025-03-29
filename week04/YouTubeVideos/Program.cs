using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Restoration of the Gospel of Jesus Christ", "ChurchofJesusChrist", 420);
        video1.AddComment(new Comment("Emma", "This video really strengthened my testimony."));
        video1.AddComment(new Comment("Joseph", "So powerful and inspiring."));
        video1.AddComment(new Comment("Olivia", "I felt the Spirit so strongly while watching this."));

        Video video2 = new Video("President Nelson: The Power of Spiritual Momentum", "ChurchofJesusChrist", 540);
        video2.AddComment(new Comment("Lucas", "President Nelson’s words always lift me up."));
        video2.AddComment(new Comment("Sophia", "Exactly what I needed today."));
        video2.AddComment(new Comment("Noah", "Such a motivating and hopeful message."));

        Video video3 = new Video("Book of Mormon Videos: 1 Nephi", "BookofMormonCentral", 360);
        video3.AddComment(new Comment("Liam", "These visuals help me understand the scriptures better."));
        video3.AddComment(new Comment("Ava", "I love seeing the stories come to life!"));
        video3.AddComment(new Comment("Ethan", "This series has deepened my love for the Book of Mormon."));

        Video video4 = new Video("The Life of Jesus Christ - Bible Videos", "BibleVideos", 600);
        video4.AddComment(new Comment("Isabella", "This brought tears to my eyes."));
        video4.AddComment(new Comment("Mason", "His love and sacrifice mean everything."));
        video4.AddComment(new Comment("Mia", "A beautiful reminder of Christ’s life and teachings."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
