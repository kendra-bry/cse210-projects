namespace EventPlanner
{
    public class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private Address _address;

        public Event(string title, string desc, DateTime date, Address address)
        {
            _title = title;
            _description = desc;
            _date = date;
            _address = address;
        }

        public void DisplayStandardDetails()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine($"Event Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Date and Time: {_date}");
            Console.WriteLine($"Address: {_address.GetAddressString()}");
        }

        public void DisplayShortDescription()
        {
            Console.WriteLine("\n-------------------------------------\n");
            Console.WriteLine($"Event Title: {_title}");
            Console.WriteLine($"Type: {GetType().Name}");
            Console.WriteLine($"Date and Time: {_date}");
        }
    }
}