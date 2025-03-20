// Mon Carlo R. Alalan
// CSE 210 Team 02 - Wednesdays 16:00 (UTC-0)
// W03 Project: Scripture Memorizer Program

using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            visibleWords[random.Next(visibleWords.Count)].Hide();
            visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + "\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
