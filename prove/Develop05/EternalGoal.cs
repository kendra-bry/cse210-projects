namespace Tracker
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }
        public EternalGoal(string name, string desc, int points, bool status) : base(name, desc, points, status) { }

        public override int MarkAsCompleted()
        {
            return GetPoints();
        }
    }
}