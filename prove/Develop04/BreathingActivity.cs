namespace mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string desc) : base(name, desc)
        { }

        public override void RunActivity()
        {
            Console.Clear();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            while (startTime < endTime)
            {
                Console.WriteLine();

                Console.Write("Breathe in... ");
                Thread.Sleep(1000);
                Animations.Countdown(3);

                Console.WriteLine();

                Console.Write("Breathe out... ");
                Thread.Sleep(1000);
                Animations.Countdown(3);

                startTime = DateTime.Now;
            }
        }
    }
}