namespace VideoTracker
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = length;
            _comments = new();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetVideoLength()
        {
            return _lengthInSeconds;
        }

        public void DisplayComments()
        {
            foreach (Comment comment in _comments)
            {
                Console.WriteLine(comment.DisplayComment());
            }
        }
    }

}