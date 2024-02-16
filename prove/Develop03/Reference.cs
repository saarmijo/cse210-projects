public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endingVerse;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endingVerse = "";
    }
    public Reference(string book, string chapter, string verse, string endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endingVerse = endingVerse;
    }
        public string GetReferenceString()
    {
        if (_endingVerse == null)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endingVerse}";
        }
    }
}