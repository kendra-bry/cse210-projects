namespace EventPlanner
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        public Reception(string title, string desc, DateTime date, Address address, string email) : base(title, desc, date, address)
        {
            _rsvpEmail = email;
        }

        public void DisplayFullDetails()
        {
            DisplayStandardDetails();
            Console.WriteLine($"RSVP: {_rsvpEmail}");
        }
    }
}