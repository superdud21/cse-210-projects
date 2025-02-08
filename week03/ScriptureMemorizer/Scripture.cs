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

    }

    public bool IsCompletelyHidden() 
    {

    }

    public string GetDisplayText()
    {

    }
}