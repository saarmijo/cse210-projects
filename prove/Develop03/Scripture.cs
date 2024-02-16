public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public string GetReference()
    {
        return _reference.GetReferenceString();
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int wordsToHide = rand.Next(1, _words.Count / 2);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public void HideWords()
    {
        foreach (Word word in _words)
        {
            word.Hide();
        }
    }
    public string GetRenderedText()
    {
        string renderedText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                renderedText += "______ ";
            }
            else
            {
                renderedText += word.GetRenderedText() + " ";
            }
        }
        return renderedText.Trim();

    }
    public void IsCompletelyHidden()
    {

    }

    private List<Word> CreateWordList(string text)
    {
        List<Word> wordList = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            wordList.Add(new Word(word));
        }
        return wordList;
    }
}