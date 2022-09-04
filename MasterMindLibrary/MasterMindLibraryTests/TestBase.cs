using MasterMindLibrary;

namespace MasterMindLibraryTests;

public class TestBase
{
    protected Word CreateWord(int length)
    {
        return new Word
        {
            CorrectMatches = new bool[length],
            IncludeMatches = new bool[length],
            IncorrectMatches = new bool[length]
        };
    }
}