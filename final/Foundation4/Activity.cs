namespace ExerciseTracker
{
    public class Activity
    {
        private DateTime _date;
        private int _minutes;

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        public string GetDate()
        {
            return _date.ToString("dd MMM yyyy");
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public virtual string GetSummary()
        {
            return string.Empty;
        }
    }
}