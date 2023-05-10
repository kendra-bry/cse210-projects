using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAssignment math = new("John Smith", "Multiplication", "Section 10.4", "Problems 3 -6");
            Console.WriteLine(math.GetSummary());
            Console.WriteLine(math.GetHomeworkList());

            WritingAssignment writing = new("John Smith", "Shakespeare", "Romeo and Juliet");
            Console.WriteLine(writing.GetSummary());
            Console.WriteLine(writing.GetWritingInfo());
        }
    }

}