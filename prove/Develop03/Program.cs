class Program
{
    static void Main()
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);
        List<string> words = scripture.GetWords();
        string referenceText = reference.GetChapter();

        Word word = new Word(words, referenceText);
        word.HideWords();
    }
}
