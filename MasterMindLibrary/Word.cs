namespace MasterMindLibrary;

public class Word
{
    public string TryWord { get; set; }
    public bool[] CorrectMatches { get; set; } 
    public bool[] IncludeMatches { get; set; } 
    public bool[] IncorrectMatches { get; set; }

    public void Match(char letter, int i, string originWord)
    {
        var originLetter = originWord[i];
        var match = originLetter.Equals(letter);
        CorrectMatches[i] = match;
        IncorrectMatches[i] = !match;
        IncludeMatches[i] = originWord.Contains(letter);
    }
}