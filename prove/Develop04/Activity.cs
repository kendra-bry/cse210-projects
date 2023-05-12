namespace mindfulness
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string desc)
        {
            _name = name;
            _description = desc;
        }


        public void BeginIntro()
        {
            Console.WriteLine($"Welcome to the {_name} Activity.\n");
            Console.WriteLine(_description);
            Console.WriteLine("\nHow long, in seconds, would you like for your session?");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready.");
            // TODO: Display Spinner for 5 seconds.
        }

        public void FinishActivity()
        {
            Console.WriteLine("Well done.");
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        }
    }
}