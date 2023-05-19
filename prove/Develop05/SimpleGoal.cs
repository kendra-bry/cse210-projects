namespace Tracker
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string desc, int points) : base(name, desc, points) { }
        public SimpleGoal(string name, string desc, int points, bool status) : base(name, desc, points, status) { }
    }
}