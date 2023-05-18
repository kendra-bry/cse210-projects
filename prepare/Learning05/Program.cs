namespace ShapesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new() { };
            shapes.Add(new Square("Red", 5));
            shapes.Add(new Rectangle("Pink", 5, 4));
            shapes.Add(new Square("White", 5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetColor());
                Console.WriteLine(shape.GetArea());
            }
        }
    }

}