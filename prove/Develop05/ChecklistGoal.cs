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

        public int GetBonus()
        {
            return _bonus;
        }

        public int GetCompletionCount()
        {
            return _completionCount;
        }

        public void SetCompletionCount(int count)
        {
            _completionCount = count;
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
    }
}