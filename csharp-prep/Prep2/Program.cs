using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercent = int.Parse(gradeInput);
        string letter;
        bool passed = true;
        string gradeModifier = "";

        char[] gradeChars = gradeInput.ToCharArray();
        List<int> gradeList = new List<int>();

        foreach (char digit in gradeChars)
        {
            gradeList.Add(int.Parse(digit.ToString()));
        }

        if (gradeList.Count > 1)
        {
            if (gradeList[1] >= 7 && gradePercent < 90 && gradePercent >= 60)
            {
                gradeModifier = "+";
            }
            else if (gradeList[1] <= 3 && gradePercent <= 93 && gradePercent >= 60)
            {
                gradeModifier = "-";
            }
        }

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }

        Console.WriteLine($"Your grade: {letter}{gradeModifier}.");

        if (passed)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else{
            Console.WriteLine("I'm sorry. You did not pass. Please try again.");
        }
    }
}