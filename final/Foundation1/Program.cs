public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and add videos to the list
        Video video1 = new Video("Video 1 Title", "Author 1", 300);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Very informative.");
        video1.AddComment("User3", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Video 2 Title", "Author 2", 450);
        video2.AddComment("User4", "Awesome content!");
        video2.AddComment("User5", "Keep up the good work.");
        video2.AddComment("User6", "Looking forward to more videos.");
        videos.Add(video2);

        Video video3 = new Video("Video 3 Title", "Author 3", 200);
        video3.AddComment("User7", "Not bad.");
        video3.AddComment("User8", "Could be better.");
        video3.AddComment("User9", "I enjoyed this.");
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}