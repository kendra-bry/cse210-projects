namespace EventPlanner
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string desc, DateTime date, Address address, string speaker, int capacity) : base(title, desc, date, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public void DisplayFullDetails()
        {
            DisplayStandardDetails();
            Console.WriteLine($"Speaker: {_speaker}");
            Console.WriteLine($"Guest Limit: {_capacity}");
        }
    }
}