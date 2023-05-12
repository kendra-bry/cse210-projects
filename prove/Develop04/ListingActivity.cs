namespace mindfulness
{
    public class ListingActivity : Activity
    {
        public ListingActivity(string name, string desc) : base(name, desc)
        { }
        public void RunActivity()
        {
            Console.WriteLine("Run Listing Activity");
            Animations.Countdown(5);
        }
    }
}