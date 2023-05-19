/*
    To exceed expectations, I added a celebration function that checks if you've completed all non-eternal goals. If you, there will be confetti displayed in the console.
*/

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

            Console.Clear();
            while (input != 6)
            {
                Console.WriteLine($"You have {tracker.GetTotalPoints()} points.\n");
                Console.WriteLine("Menu Options:");

                foreach (string option in menuOptions)
                {
                    Console.WriteLine(option);
                }
                Console.Write("\nPlease choose a menu option. ");
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
                        tracker.RecordEvent();
                        break;
                    case 4:
                        tracker.SaveFile();
                        break;
                    case 5:
                        tracker.LoadFile();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Thank you for recording your goals today. Good bye.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I'm sorry. That is not a valid option.");
                        break;
                }
            }
        }
    }

}