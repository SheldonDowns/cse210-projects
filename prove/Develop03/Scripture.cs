using System;
using System.Collections.Generic;

class Scripture
{
    private string _scriptureText;
    private List<string> _words;

    public Scripture(Reference reference)
    {
        _scriptureText = reference.GetScripture();
        _words = new List<string>(_scriptureText.Split(' '));
    }

    public List<string> GetWords()
    {
        return _words;
    }
}
