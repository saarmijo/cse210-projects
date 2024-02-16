public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text, bool hidden = false)
    {
        _text = text;
        _hidden = hidden;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public string GetRenderedText()
    {
        if (IsHidden())
        {
            return new string('_', GetText().Length);
        }
        else
        {
            return GetText();
        }
    }
}
