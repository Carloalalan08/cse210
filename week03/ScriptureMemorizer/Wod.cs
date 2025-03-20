// Mon Carlo R. Alalan
// CSE 210 Team 02 - Wednesdays 16:00 (UTC-0)
// W03 Project: Scripture Memorizer Program

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
