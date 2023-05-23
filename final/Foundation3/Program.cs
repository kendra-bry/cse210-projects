namespace EventPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addy1 = new("123 Easy Street", "Sunnyville", "CA", "USA");
            Lecture lecture = new("Tech Summit", "Come learn about the new up and coming technology.", new DateTime(2023, 7, 25, 11, 0, 0), addy1, "Michael Smith", 300);

            lecture.DisplayStandardDetails();
            lecture.DisplayFullDetails();
            lecture.DisplayShortDescription();

            Address addy2 = new("ABC Main Street", "Scranton", "PA", "USA");
            Reception reception = new("Schrute Wedding", "Come celebrate the marriage of Dwight Schrute and Angela Martin.", new DateTime(2023, 8, 5, 15, 45, 0), addy2, "dshrute@dunder.com");

            reception.DisplayStandardDetails();
            reception.DisplayFullDetails();
            reception.DisplayShortDescription();

            Address addy3 = new("Camp Ground Drive", "Lewiston", "ME", "USA");
            Outdoor outdoor = new("Summer Camp", "Summer camp for kids ages 10 - 12.", new DateTime(2023, 6, 1, 8, 0, 0), addy3, "Mostly sunny. Temps reaching 80 degrees.");

            outdoor.DisplayStandardDetails();
            outdoor.DisplayFullDetails();
            outdoor.DisplayShortDescription();
        }
    }

}
