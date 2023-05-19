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
            Console.Clear();
            Console.WriteLine("The goals are:");

            foreach (Goal goal in _goals)
            {
                int index = _goals.FindIndex(g => g.GetName() == goal.GetName());
                string name = goal.GetName();
                Console.WriteLine($"  {index + 1}. {name} - (Worth {goal.GetPoints()} points)");
            }

            Console.Write("\nWhich goal would you like to record an event for? ");
            int input = int.Parse(Console.ReadLine());

            Goal selectedGoal = _goals[input - 1];
            _totalPoints += selectedGoal.MarkAsCompleted();

            Console.WriteLine("\nGoal updated.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void SaveFile()
        {
            Console.Clear();
            Console.Write("What is the file name? (Don't include the file extension.) ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter($"{filename}.txt"))
            {
                outputFile.WriteLine($"Total Points|{_totalPoints}");
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.PrepareForSave());
                }
            }

            Console.WriteLine("\nGoals saved.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public void LoadFile()
        {
            _goals.Clear();
            Console.Clear();

            Console.Write("What is the name of the file you would like to load? (Don't include the file extension.) ");
            string filename = Console.ReadLine();
            string[] lines = File.ReadAllLines($"{filename}.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                if (parts.Length == 2)
                {
                    _totalPoints = int.Parse(parts[1]);
                }
                else
                {
                    ParseTextLine(parts);
                }
            }

            Console.WriteLine("\nGoals loaded.");
            Thread.Sleep(2000);
            Console.Clear();
        }

        private void ParseTextLine(string[] line)
        {
            string type = line[0];
            string name = line[1];
            string desc = line[2];
            int points = int.Parse(line[3]);
            bool status = bool.Parse(line[4]);

            switch (type)
            {
                case "SimpleGoal":
                    SimpleGoal sg = new(name, desc, points, status);
                    _goals.Add(sg);
                    break;
                case "EternalGoal":
                    EternalGoal eg = new(name, desc, points, status);
                    _goals.Add(eg);
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(line[5]);
                    int completionCount = int.Parse(line[6]);
                    int total = int.Parse(line[7]);

                    ChecklistGoal cg = new(name, desc, points, status, bonus, completionCount, total);
                    _goals.Add(cg);
                    break;
            }
        }
    }
}