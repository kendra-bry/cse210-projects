namespace mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string desc) : base(name, desc)
        { }

        public void RunActivity()
        {
            Console.WriteLine("Running Breathing Activity");
            Animations.Countdown(5);
        }
        /*
            Display: a series of messages alternating between "Breathe in..." and "Breathe out..."
            Stretch Display: Breathing animation.
            Display: pause for several seconds and show a countdown.
        */
    }
}