using System.Threading;
namespace mindfulness
{
    public class Animations
    {
        public static void Spinner(int duration)
        {
            List<string> animationStrings = new();

            List<string> animationTemplate = new()
            {
                "|",
                "/",
                "-",
                "\\",
            };

            for (int i = 0; i < duration; i++)
            {
                animationStrings.AddRange(animationTemplate);
            }

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }

        public static void Countdown(int duration)
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                if (i > 9)
                {
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
        }

        public static void Ellipsis(int duration)
        {
            for (int i = 1; i <= duration; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
                if (i % 3 == 0)
                {
                    Console.Write("\b\b\b   \b\b\b");
                }
            }
        }

        public static void Breathing()
        {
            Console.WriteLine("Breathing");
        }
    }
}