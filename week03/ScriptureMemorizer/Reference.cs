// Mon Carlo R. Alalan
// CSE 210 Team 02 - Wednesdays 16:00 (UTC-0)
// W03 Project: Scripture Memorizer Program

class Reference
{
    private string _referenceText;

    public Reference(string referenceText)
    {
        _referenceText = referenceText;
    }

    public string GetDisplayText()
    {
        return _referenceText;
    }
}
