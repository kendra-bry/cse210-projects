namespace EventPlanner
{
    public class Outdoor : Event
    {
        private string _forecast;

        public Outdoor(string title, string desc, DateTime date, Address address, string forecast) : base(title, desc, date, address)
        {
            _forecast = forecast;
        }

        public void DisplayFullDetails()
        {
            DisplayStandardDetails();
            Console.WriteLine($"Weather Forecast: {_forecast}");
        }
    }
}