namespace MasterMindLibrary;

public class Word
{
    public string OriginWord { get; set; }
    public bool[] CorrectMatches { get; set; } 
    public bool[] IncludeMatches { get; set; } 
    public bool[] IncorrectMatches { get; set; }

    public bool Match(string word)
    {
        return OriginWord.Equals(word);
    }

    public void Match(char letter, int i)
    {
        var originLetter = OriginWord[i];
        var match = originLetter.Equals(letter);
        CorrectMatches[i] = match;
        IncorrectMatches[i] = !match;
        IncludeMatches[i] = OriginWord.Contains(letter);
    }
}