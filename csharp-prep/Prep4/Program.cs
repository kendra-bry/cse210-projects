using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        List<int> numberList = new();

        do
        {
            Console.Write("Enter a number. (Type 0 to quit.): ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numberList.Add(num);
            }
        }
        while (num != 0);
        
        int total = numberList.Sum();
        Console.WriteLine($"\nTotal: {total}");

        double ave = numberList.Average();
        Console.WriteLine($"Average: {ave}");

        int max = numberList.Max();
        Console.WriteLine($"Max: {max}");

        int min = numberList.Min();
        Console.WriteLine($"Min: {min}");
    }
}