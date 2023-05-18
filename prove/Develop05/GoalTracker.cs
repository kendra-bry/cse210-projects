namespace Tracker
{
    public class GoalTracker
    {
        private int _totalPoints;
        private List<Goal> _goals = new();

        public GoalTracker(int totalPoints)
        {
            _totalPoints = totalPoints;
        }

        public int GetTotalPoints()
        {
            return _totalPoints;
        }

        public void SetTotalPoints(int totalPoints)
        {
            _totalPoints = totalPoints;
        }

        public void AddGoal()
        {
            Console.Clear();
            List<string> goalTypes = new()
            {
                "  1. Simple Goal",
                "  2. Eternal Goal",
                "  3. Checklist Goal"
            };

            Console.WriteLine("The available goal types are:");
            foreach (string type in goalTypes)
            {
                Console.WriteLine(type);
            }
            
            Console.Write("\nWhich type of goal would you like to add? ");
            int input = int.Parse(Console.ReadLine());

            if (input < 1 && input > 4)
            {
                throw new Exception("I'm sorry. That is not a valid option.");
            }

            Console.Write("\nWhat is the name of the new goal? ");
            string name = Console.ReadLine();

            Console.Write("Please add a short description for the goal. ");
            string desc = Console.ReadLine();

            Console.Write("How many points is it worth? ");
            int points = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    SimpleGoal sg = new(name, desc, points);
                    _goals.Add(sg);
                    break;
                case 2:
                    EternalGoal eg = new(name, desc, points);
                    _goals.Add(eg);
                    break;
                case 3:
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int completionCount = int.Parse(Console.ReadLine());

                    Console.Write($"What is the bonus for accomplishing this goal {completionCount} times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal cg = new(name, desc, points, bonus, completionCount);
                    _goals.Add(cg);
                    break;
            }
            Console.WriteLine("\nNew goal added.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("The goals in the list are:");
            foreach (Goal goal in _goals)
            {
                int index = _goals.FindIndex(g => g.GetName() == goal.GetName());
                Console.WriteLine($"{index + 1}. {goal.GetListText()}");
            }
            Thread.Sleep(2000);
            Console.WriteLine();
        }

        public void RecordEvent()
        {

        }

        public void SaveFile()
        {

        }

        public void LoadFile()
        {

        }
    }
}