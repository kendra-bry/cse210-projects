public class Entry
{
    // Properties
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string _prompt, string _response, string _date)
    {
        this._prompt = _prompt;
        this._response = _response;
        this._date = _date;
    }
    // Methods
    public void DisplayEntry()
    {
        Console.WriteLine($"\n{_date}");
        Console.WriteLine(_prompt);
        Console.WriteLine(_response);
    }

    public string PrepareForSave()
    {
        return string.Format("{0}|{1}|{2}", _date, _prompt, _response);
    }

}