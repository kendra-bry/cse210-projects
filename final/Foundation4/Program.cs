namespace ExerciseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new()
            {
                new Cycling(DateTime.Today, 30, 6.0),
                new Swimming(DateTime.Today, 30, 20),
                new Running(DateTime.Today, 30, 3.0),
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }

}
