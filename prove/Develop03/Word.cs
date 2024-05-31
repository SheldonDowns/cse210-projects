using System;
using System.Collections.Generic;

class Word
{
    private List<string> _words;
    private Random _random;
    private string _reference;

    public Word(List<string> words, string reference)
    {
        _words = new List<string>(words);
        _random = new Random();
        _reference = reference;
    }

    public void HideWords()
    {
        HashSet<int> hiddenIndices = new HashSet<int>();
        while (hiddenIndices.Count < _words.Count)
        {
            Console.Clear();
            PrintScripture(hiddenIndices);

            Console.WriteLine("Press 'Enter' to hide three words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            HideRandomWords(hiddenIndices, 3);
        }
    }

    private void HideRandomWords(HashSet<int> hiddenIndices, int count)
    {
        int hiddenCount = 0;

        while (hiddenCount < count && hiddenIndices.Count < _words.Count)
        {
            int index;
            do
            {
                index = _random.Next(_words.Count);
            } while (hiddenIndices.Contains(index));

            hiddenIndices.Add(index);
            _words[index] = new string('_', _words[index].Length);
            hiddenCount++;
        }
    }

    private void PrintScripture(HashSet<int> hiddenIndices)
    {
        Console.WriteLine($"{_reference} {string.Join(" ", _words)}");
    }
}
