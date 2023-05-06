class Program
{

    static async Task Main(string[] args)
    {
        DataAccess dataAccess = new();
        try
        {
            Console.WriteLine("\nWelcome to the scripture memorizer helper.\n");
            string instructions = "Press enter or type 'quit' to finish. ";
            Console.Write(instructions);

            string input = Console.ReadLine();

            if (input == "quit")
            {
                return;
            }

            Scripture scripture = await dataAccess.FetchScripture();
            scripture.GetWords();

            while (input != "quit" && !scripture.GetIsCompletelyHidden())
            {
                Console.Clear();
                scripture.DisplayScripture();
                scripture.SetIsCompletelyHidden();

                if (scripture.GetIsCompletelyHidden())
                {
                    break;
                }

                Console.Write(instructions);
                input = Console.ReadLine();

                scripture.HideWords();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}