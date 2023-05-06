using System.Text.Json;
using JsonClasses;

public class DataAccess
{
    public async Task<Scripture> FetchScripture()
    {
        using (HttpClient client = new())
        {
            string baseUrl = "https://api.nephi.org";
            // string query = GetQuery();
            string query = "John 3:5-7";

            var responseString = await client.GetStringAsync($"{baseUrl}/scriptures/?q={query}");

            if (!string.IsNullOrWhiteSpace(responseString))
            {
                return CreateScriptureFromResponse(responseString);
            }
            else
            {
                throw new Exception("I'm sorry. That scripture reference was not found.");
            }
        }
    }

    public static string GetQuery()
    {
        Console.Write("\nWhat is the name of the book? ");
        string book = Console.ReadLine();
        Console.Write("Which chapter? ");
        string chapter = Console.ReadLine();
        Console.Write("Which verse? ");
        string verseStart = Console.ReadLine();
        string verseEnd = string.Empty;

        Console.Write("Do you want to memorize more than one verse? (Y/N) ");
        string response = Console.ReadLine().ToLower();

        string query = $"{book} {chapter}:{verseStart}";
        if (response == "y")
        {
            Console.Write("Which verse? ");
            verseEnd = Console.ReadLine();
            query += $"-{verseEnd}";
        }

        return query;
    }

    private static Scripture CreateScriptureFromResponse(string responseString)
    {
        var response = JsonSerializer.Deserialize<ScriptureApiResponse>(responseString);

        if (response.Scriptures.Length < 1)
        {
            throw new Exception("I'm sorry. That scripture reference was not found.");
        }

        Reference reference = CreateReference(response);
        string verse = CreateVerseString(response);
        Scripture scripture = new(reference, verse);

        return scripture;
    }

    private static Reference CreateReference(ScriptureApiResponse response)
    {
        string book = response.Scriptures[0].Book;
        string chapter = response.Scriptures[0].Chapter.ToString();
        string verseStart = response.Scriptures[0].Verse.ToString();

        if (response.Scriptures.Length > 1)
        {
            var lastIndex = response.Scriptures.Length - 1;
            string verseEnd = response.Scriptures[lastIndex].Verse.ToString();
            return new(book, chapter, verseStart, verseEnd);
        }

        return new(book, chapter, verseStart);
    }

    private static string CreateVerseString(ScriptureApiResponse response)
    {
        string verse = string.Empty;

        foreach (Scriptures scripture in response.Scriptures)
        {
            verse += $"{scripture.Verse} {scripture.Text}\n";
        }

        return verse;
    }
}