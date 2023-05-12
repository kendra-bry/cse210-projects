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
            Animations.Ellipsis(3);
            Console.Write("\nHow long, in seconds, would you like your session to run? ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get ready.");
            Animations.Spinner(2);
        }

        public void FinishActivity()
        {
            Console.WriteLine("Well done.");
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        }
    }
}