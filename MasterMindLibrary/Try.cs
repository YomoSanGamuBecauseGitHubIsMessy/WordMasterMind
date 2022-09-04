namespace MasterMindLibrary;

public class Try
{
    public bool Used { get; set; }
    public Word Word { get; set; }

    public Match GetMatch(int i)
    {
        if (Word.CorrectMatches[i])
            return Match.Match;
        if (Word.IncludeMatches[i])
            return Match.Include;
        if (Word.IncorrectMatches[i])
            return Match.NoMatch;
        return Match.Nothing;
    }
}