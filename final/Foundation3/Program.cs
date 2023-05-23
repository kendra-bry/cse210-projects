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
        }
    }

}
