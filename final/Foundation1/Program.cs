namespace VideoTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<Video> videos = new();
            Video vid1 = new("Disneyland Opening Day", "Walt Disney", 90);
            vid1.AddComment(new Comment("Mickey Mouse", "This is the best thing ever."));
            vid1.AddComment(new Comment("Goofy", "Gawrsh"));
            vid1.AddComment(new Comment("Stinky Pete", "Awful. Would not recommend."));
            videos.Add(vid1);

            Video vid2 = new("Google Launch Party", "Larry Page, Sergey Brin", 150);
            vid2.AddComment(new Comment("AskJeeves", "Seems harmless."));
            vid2.AddComment(new Comment("Yahoo", "If I could give this 0 stars, I would."));
            vid2.AddComment(new Comment("Microsoft", "That's cute."));
            videos.Add(vid2);

            Video vid3 = new("The Moon Landing", "NASA", 300);
            vid3.AddComment(new Comment("Joe Schmoe", "That's pretty neat!"));
            vid3.AddComment(new Comment("Guy who lives under a rock", "The production quality on this Hollywood movie is terrible."));
            vid3.AddComment(new Comment("Russia", "Nooooooo!"));
            vid3.AddComment(new Comment("Buzz Aldrin", "Wow, that really WAS a small step."));
            videos.Add(vid3);

            foreach (Video video in videos)
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Video Length: {video.GetVideoLength()} seconds\n");
                Console.WriteLine($"Comments ({video.GetCommentCount()}):");
                video.DisplayComments();
                Console.WriteLine("-----------------------------------------------\n");
            }
        }
    }

}