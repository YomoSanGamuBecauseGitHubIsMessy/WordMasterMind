namespace MasterMindLibrary;

public class Try
{
    public bool Used { get; set; }
    public string TryWord { get; set; }
    public bool[] CorrectMatches { get; set; }
    public bool[] IncludeMatches { get; set; }
    public bool[] IncorrectMatches { get; set; }
    public void MatchLetter(char letter, int i, string originWord, IDictionary<char, int> doubleLetters)
    {
        var originLetter = originWord[i];
        if(doubleLetters[letter] > 0)
        {
            var match = originLetter.Equals(letter);
            CorrectMatches[i] = match;
            IncorrectMatches[i] = !match;
            IncludeMatches[i] = originWord.Contains(letter);
            doubleLetters[letter]--;
        }
        else
        {
            CorrectMatches[i] = false;
            IncorrectMatches[i] = true;
            IncludeMatches[i] = false;
        }
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