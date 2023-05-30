namespace ExerciseTracker
{
    public class Cycling : Activity
    {
        private double _speed;
        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / GetSpeed();
        }

        public override string GetSummary()
        {
            return $"{GetDate()} {GetType().Name} ({GetMinutes()} min) - Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        }

    }
}