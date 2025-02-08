public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public void HideWords()
    {
        List<Word> visibleWords = new List<Word>();

        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count > 0)
        {
            Random random = new Random();
            int randomWordIndex = random.Next(visibleWords.Count);
            visibleWords[randomWordIndex].Hide();
        }
    }

    public bool IsCompletelyHidden() 
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}