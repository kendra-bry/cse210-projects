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
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity.");
            Animations.Ellipsis(3);
            Console.WriteLine();

            Console.WriteLine(_description);
            Animations.Ellipsis(6);

            Console.Write("\nHow long, in seconds, would you like your session to run? ");
            _duration = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write($"Get ready. The {_name} Activity will start in: ");
            Animations.Countdown(3);

            RunActivity();
            FinishActivity();
        }

        public void FinishActivity()
        {
            Console.Clear();
            Console.WriteLine("Well done.");
            Animations.Spinner(2);
            Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
            Animations.Spinner(2);
        }

        public virtual void RunActivity()
        { }
    }
}