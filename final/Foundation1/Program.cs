using System;
using System.Collections.Generic;

// Represents a comment made on a video
class Comment
{
    public string CommenterName { get; set; } // Stores commenter's name
    public string Text { get; set; } // Stores the comment text
}

// Represents a YouTube video and its associated comments
class Video
{
    public string Title { get; set; } // Stores the video title
    public string Author { get; set; } // Stores the video author
    public int LengthInSeconds { get; set; } // Stores the length of the video in seconds
    private List<Comment> comments; // List to store comments associated with the video

    // Constructor to initialize the list of comments for a video
    public Video()
    {
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments associated with the video
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Method to display information about the video along with its comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>(); // List to store video objects

        // Creating and initializing Video objects
        Video video1 = new Video
        {
            Title = "New Synthesizer Review",
            Author = "Channel Name",
            LengthInSeconds = 300 // 5 minutes
        };
        // Adding comments to video1
        video1.AddComment(new Comment { CommenterName = "User1", Text = "Great showcase, you earned a like and a new subscriber!" });
        video1.AddComment(new Comment { CommenterName = "User2", Text = "This looks like a very powerful instrument." });
        video1.AddComment(new Comment { CommenterName = "User3", Text = "Could have used a different sample." });

        videos.Add(video1); // Adding video1 to the list of videos

        // Creating and initializing another Video object
        Video video2 = new Video
        {
            Title = "Unboxing of Product",
            Author = "Instrument Reviewer",
            LengthInSeconds = 180 // 3 minutes
        };
        // Adding comments to video2
        video2.AddComment(new Comment { CommenterName = "User4", Text = "I want to buy this!" });
        video2.AddComment(new Comment { CommenterName = "User5", Text = "Is there a link to find this product?" });

        videos.Add(video2); // Adding video2 to the list of videos

        // Add more videos here...

        // Displaying information for each video in the list
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
