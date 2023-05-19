namespace Tracker
{
    public class ChecklistGoal : Goal
    {
        private readonly int _bonus;
        private int _completionCount;
        private readonly int _totalCountToBeCompleted;
        public ChecklistGoal(string name, string desc, int points, int bonus, int totalRequired) : base(name, desc, points)
        {
            _bonus = bonus;
            _completionCount = 0;
            _totalCountToBeCompleted = totalRequired;
        }
        public ChecklistGoal(string name, string desc, int points, bool status, int bonus, int completionCount, int totalRequired) : base(name, desc, points, status)
        {
            _bonus = bonus;
            _completionCount = completionCount;
            _totalCountToBeCompleted = totalRequired;
        }

        public int GetCompletionCount()
        {
            return _completionCount;
        }

        public int GetTotalToBeCompleted()
        {
            return _totalCountToBeCompleted;
        }

        public override string GetListText()
        {
            string listText = base.GetListText();
            listText += $" -- Currently completed: {GetCompletionCount()}/{GetTotalToBeCompleted()}.";
            return listText;
        }

        public override int MarkAsCompleted()
        {
            int points = GetPoints();
            int count = _completionCount;
            count++;

            if (count < _totalCountToBeCompleted)
            {
                _completionCount++;
            }
            else if (count == _totalCountToBeCompleted)
            {
                _completionCount++;
                points += _bonus;
                SetCompletionStatus();
            }

            return points;
        }

        public override string PrepareForSave()
        {
            string saveText =  base.PrepareForSave();
            return string.Format("{0}|{1}|{2}|{3}", saveText, _bonus, _completionCount, _totalCountToBeCompleted);
        }
    }
}