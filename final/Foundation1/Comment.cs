namespace VideoTracker
{
    public class Comment
    {
        private string _author;
        private string _commentText;

        public Comment(string author, string text)
        {
            _author = author;
            _commentText = text;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetCommentText()
        {
            return _commentText;
        }
        public string DisplayComment()
        {
            return $"{GetCommentText()}\n \t\t -{GetAuthor()}";
        }
    }
}