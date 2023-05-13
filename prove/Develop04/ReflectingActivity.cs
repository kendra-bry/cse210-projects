namespace mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _reflections;
        private List<int> _usedPrompts = new() { };
        private List<int> _usedReflections = new() { };
        private Random _rnd;

        public ReflectingActivity(string name, string desc) : base(name, desc)
        {
            _prompts = new() {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
            };

            _reflections = new() {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
            };

            _rnd = new Random();
        }
        public override void RunActivity()
        {
            _usedReflections.Clear();
            Console.Clear();
            Console.WriteLine(GetPrompt());
            Animations.Ellipsis(6);

            Console.WriteLine();
            Console.Write("Press Enter to continue. ");
            Console.ReadLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            while (startTime < endTime)
            {
                Console.WriteLine();
                Console.WriteLine(GetReflection());
                Animations.Spinner(5);

                startTime = DateTime.Now;
            }
        }

        private string GetPrompt()
        {
            int i = _rnd.Next(0, _prompts.Count);
            while (_usedPrompts.Contains(i))
            {
                i = _rnd.Next(0, _prompts.Count);
                if (_usedPrompts.Count == _prompts.Count)
                {
                    _usedPrompts.Clear();
                }
            }
            _usedPrompts.Add(i);
            return _prompts[i];
        }


        private string GetReflection()
        {
            int i = _rnd.Next(0, _reflections.Count);
            while (_usedReflections.Contains(i))
            {
                i = _rnd.Next(0, _reflections.Count);
                if (_usedReflections.Count == _reflections.Count)
                {
                    _usedReflections.Clear();
                }
            }
            _usedReflections.Add(i);
            return _reflections[i];
        }
    }
}