using Project.Utilities;

public class Journal
{
    // Properties
    public List<Entry> _entries = new List<Entry>();
    public string _filename;

    // Methods
    public void WriteEntry()
    {
        string date = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        string prompt = Utilities.GetPrompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry entry = new(prompt, response, date);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void LoadFromTxt()
    {
        Console.Write("What is the name of the file you would like to load? (Don't include the file extension.) ");
        _filename = Console.ReadLine();
        string[] lines = File.ReadAllLines($"{_filename}.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new(prompt, response, date);
            _entries.Add(entry);
        }
    }

    public void SaveToTxt()
    {
        Console.Write("What is the file name? (Don't include the file extension.) ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"{_filename}.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.PrepareForSave());
            }
        }
    }
}