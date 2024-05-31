using System;

class Reference
{
    private string _chapter;
    private string _script;

    public Reference()
    {
        _chapter = "John 3:16";
        _script = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
    }

    public Reference(string chapter, string script)
    {
        _chapter = chapter;
        _script = script;
    }

    public string GetScripture()
    {
        return _script;
    }

    public string GetChapter()
    {
        return _chapter;
    }
}
