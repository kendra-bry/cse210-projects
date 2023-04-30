/*
    To exceed expectations, I included asking for the user's name as well as save and load the file as a txt file.
*/

class Program
{
    static void Main(string[] args)
    {
        int _menuInput = 0;
        Journal journal = new Journal();
        string _name;

        List<string> menu = new List<string>
        {
            "\nPlease select a menu option.\n",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "\nWhat would you like to do?"
        };

        Console.Write("Hello, what is your name? ");
        _name = Console.ReadLine();
        Console.WriteLine($"Hi, {_name}. Welcome to your journal.");

        while (_menuInput != 5)
        {
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }
            _menuInput = int.Parse(Console.ReadLine());

            switch (_menuInput)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadFromTxt();
                    break;
                case 4:
                    journal.SaveToTxt();
                    break;
                case 5:
                    Console.WriteLine($"\nGoodbye, {_name}. Thank you for writing in your journal today.");
                    break;
            }
        }
    }
}