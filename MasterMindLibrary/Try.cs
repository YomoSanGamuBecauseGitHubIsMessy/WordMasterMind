namespace MasterMindLibrary;

public class Try
{
    public bool Used { get; set; }
    public string TryWord { get; set; }
    public bool[] CorrectMatches { get; set; }
    public bool[] IncludeMatches { get; set; }
    public bool[] IncorrectMatches { get; set; }

    public void MatchWord(string word, string originWord, IDictionary<char, int> doubleLetter)
    {
        IDictionary<char, int> lettersCopy = CopyLetters(doubleLetter);
        for (var i = 0; i < word.Length; i++)
        {
            var letter = word[i];
            if (!lettersCopy.ContainsKey(letter) || lettersCopy[letter] <= 0) continue;
            CorrectMatches[i] = letter == originWord[i];
            lettersCopy[letter]--;
        }

        lettersCopy = CopyLetters(doubleLetter);
        for (var i = 0; i < word.Length; i++)
        {
            var letter = word[i];
            IncludeMatches[i] = lettersCopy.ContainsKey(letter) && lettersCopy[letter] > 0;
            if(lettersCopy.ContainsKey(letter))
                lettersCopy[letter]--;
        }
        for (var i = 0; i < word.Length; i++)
        {
            var letter = word[i];
            IncorrectMatches[i] = letter != originWord[i];
        }
    }

    private Dictionary<char, int> CopyLetters(IDictionary<char, int> doubleLetter)
    {
        return doubleLetter.ToDictionary(item => item.Key, item => item.Value);
    }

    public Match GetMatch(int i)
    {
        if (CorrectMatches[i])
            return Match.Match;
        if (IncludeMatches[i])
            return Match.Include;
        if (IncorrectMatches[i])
            return Match.NoMatch;
        return Match.Nothing;
    }
}