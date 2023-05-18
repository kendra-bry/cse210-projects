namespace Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<string> menuOptions = new()
            {
                "  1. Create new goal",
                "  2. List goals",
                "  3. Record event",
                "  4. Save goals",
                "  5. Load goals",
                "  6. Quit",
            };

            GoalTracker tracker = new(0);

            int totalPoints = 0;

            Console.Clear();
            while (input != 6)
            {
                Console.WriteLine($"You have {totalPoints} points.\n");
                Console.WriteLine("Menu Options:");

                foreach (string option in menuOptions)
                {
                    Console.WriteLine(option);
                }
                Console.Write("Please choose a menu option. ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        tracker.AddGoal();
                        break;
                    case 2:
                        tracker.ListGoals();
                        break;
                    case 3:
                        Console.WriteLine("Recording event");
                        break;
                    case 4:
                        Console.WriteLine("Saving goals");
                        break;
                    case 5:
                        Console.WriteLine("Loading goals");
                        break;
                    case 6:
                        Console.WriteLine("Quitting");
                        break;
                    default:
                        Console.WriteLine("I'm sorry. That is not a valid option.");
                        break;
                }
            }
        }
    }

}