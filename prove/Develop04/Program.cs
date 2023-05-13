namespace mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<string> menuOptions = new()
            {
                "  1. Start breathing activity",
                "  2. Start listing activity",
                "  3. Start reflecting activity",
                "  4. Quit"
            };

            while (input != 4)
            {
                Console.Clear();
                Console.WriteLine("Menu options:");
                foreach (string option in menuOptions)
                {
                    Console.WriteLine(option);
                }
                Console.Write("Please choose a menu number. ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        string b_name = "Breathing";
                        string b_desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                        BreathingActivity breathing = new(b_name, b_desc);
                        breathing.BeginIntro();
                        break;
                    case 2:
                        string l_name = "Listing";
                        string l_desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        ListingActivity listing = new(l_name, l_desc);
                        listing.BeginIntro();
                        break;
                    case 3:
                        string r_name = "Reflecting";
                        string r_desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                        ReflectingActivity reflecting = new(r_name, r_desc);
                        reflecting.BeginIntro();
                        break;
                    case 4:
                    default:
                        Console.WriteLine("Thank you for being mindful today.");
                        break;
                }
            }

        }
    }

}