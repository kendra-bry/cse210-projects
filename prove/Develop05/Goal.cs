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

        public Goal(string name, string desc, int points, bool status)
        {
            _name = name;
            _description = desc;
            _points = points;
            _isCompleted = status;
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

        public void SetCompletionStatus()
        {
            _isCompleted = true;
        }

        public virtual int MarkAsCompleted()
        {
            _isCompleted = true;
            return _points;
        }

        public virtual string GetListText()
        {
            string completed = CheckCompletionStatus() ? "[X]" : "[ ]";
            string text = $"{completed} {GetName()} ({GetDesc()})";
            return text;
        }

        public virtual string PrepareForSave()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}", GetType().Name, _name, _description, _points, _isCompleted);
        }

    }
}