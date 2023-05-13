namespace mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _responses = new() { };
        private List<int> _usedPrompts = new() { };
        private Random _rnd;
        public ListingActivity(string name, string desc) : base(name, desc)
        {
            _prompts = new() {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",
            };

            _rnd = new Random();
        }
        public override void RunActivity()
        {
            Console.Clear();
            Console.WriteLine(GetPrompt());
            Animations.Spinner(3);

            Console.Write("\nPress Enter to continue. ");
            Console.ReadLine();

            Animations.Countdown(3);
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            while (startTime < endTime)
            {
                GetResponse();
                startTime = DateTime.Now;
            }

            Console.Clear();
            Console.WriteLine($"Time is finished. You wrote {_responses.Count} responses.");
            Animations.Spinner(3);
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

        private void GetResponse()
        {
            string response = Console.ReadLine();
            _responses.Add(response);
        }
    }
}