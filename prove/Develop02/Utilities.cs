using Project.Enums;

namespace Project.Utilities
{
    public static class Utilities
    {
        public static string GetPrompt()
        {
            Random rnd = new Random();
            PromptEnum promptNum = (PromptEnum)rnd.Next(1, Enum.GetNames(typeof(PromptEnum)).Length);

            return GetPromptString(promptNum);
        }

        private static string GetPromptString(PromptEnum num)
        {
            switch (num)
            {
                case PromptEnum.InterestingPerson:
                    return "Who was the most interesting person I interacted with today?";
                case PromptEnum.BestPart:
                    return "What was the best part of my day?";
                case PromptEnum.HandOfGod:
                    return "How did I see the hand of the Lord in my life today?";
                case PromptEnum.StrongestEmotion:
                    return "What was the strongest emotion I felt today?";
                case PromptEnum.DoOver:
                    return "If there was something I could do over today, what would it be?";
                case PromptEnum.MostSurprising:
                    return "What was the most surprising thing to happen today?";
                case PromptEnum.MostProud:
                    return "What is something are you most proud of that happened today? ";
                case PromptEnum.Learn:
                    return "What is something you learned today?";
                case PromptEnum.LookingForward:
                    return "What is something you are looking forward to?";
                case PromptEnum.Feeling:
                    return "How are you feeling?";
                case PromptEnum.ChildhoodMemory:
                    return "What is one of your favorite childhood memories?";
                case PromptEnum.NewHabit:
                    return "What is a new habit you'd like to work on?";
                default:
                    return "What is something that made you laugh today?";
            }
        }
    }

}