public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new();
    private bool _isCompletelyHidden = false;
    private string _verse;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public void GetWords()
    {
        List<string> wordList = _verse.Split(' ').ToList();

        foreach (string wordString in wordList)
        {
            Word word = new(wordString);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
    }

    public void HideWords()
    {
        Random rnd = new();
        int hideWordCount = rnd.Next(1, 4);
        int iterator = 0;

        do
        {
            int wordListIndex = rnd.Next(0, _words.Count);
            Word selectedWord = _words[wordListIndex];
            if (!selectedWord.GetIsHidden())
            {
                string selectedWordString = selectedWord.GetWord();
                string hiddenString = string.Empty;
                foreach (char c in selectedWordString)
                {
                    hiddenString += "_";
                }
                Word word = new(hiddenString);
                word.SetIsHidden(true);
                _words[wordListIndex] = word;
                iterator++;
            }
        }
        while (iterator < hideWordCount);
    }

    public bool GetIsCompletelyHidden()
    {
        return _isCompletelyHidden;
    }

    public void SetIsCompletelyHidden()
    {
        bool everyWordIsHidden = true;
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                everyWordIsHidden = false;
            }
        }
        _isCompletelyHidden = everyWordIsHidden;
    }
}