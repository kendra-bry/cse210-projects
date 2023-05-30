namespace ExerciseTracker
{
    public class Swimming : Activity
    {
        private int _lapCount;
        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            _lapCount = laps;
        }

        public override double GetDistance()
        {
            return _lapCount * 50 / 1000 * 0.62;
        }

        public override double GetSpeed()
        {
            return GetDistance() / GetMinutes() * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{GetDate()} {GetType().Name} ({GetMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        }

    }
}