namespace Tracker
{
    public class Goal
    {
        private string _name;
        private string _description;
        private int _points;
        private bool _isCompleted;

        public Goal(string name, string desc, int points)
        {
            _name = name;
            _description = desc;
            _points = points;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDesc()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }

        public bool CheckCompletionStatus()
        {
            return _isCompleted;
        }

        public void SetCompletionStatus(bool status)
        {
            _isCompleted = status;
        }

        public virtual string GetListText()
        {
            string completed = CheckCompletionStatus() ? "[X]" : "[ ]";
            string text = $"{completed} {GetName()} ({GetDesc()})";
            return text;
        }
    }
}