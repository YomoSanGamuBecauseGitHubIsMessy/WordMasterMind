using FluentAssertions;
using FluentAssertions.Execution;
using MasterMindLibrary;
using NUnit.Framework;

namespace MasterMindLibraryTests;

[TestFixture]
public class WordTest : TestBase
{
    [TestCase("aus",'k', 0, new []{false, false, false}, new []{false, false, false}, new []{true, false, false})]
    [TestCase("aus",'u', 0, new []{false, false, false}, new []{true, false, false}, new []{true, false, false})]
    [TestCase("aus",'a', 0, new []{true, false, false}, new []{true, false, false}, new []{false, false, false})]
    public void MatchWorks(string originWord, char letter, int index, bool[] correctMatches, bool[] includeMatches,
        bool[] incorrectMatches)
    {
        var word = CreateWord(originWord.Length);
        using (new AssertionScope())
        {
            word.Match(letter, index, originWord);
            word.CorrectMatches.Should().BeEquivalentTo(correctMatches);
            word.IncludeMatches.Should().BeEquivalentTo(includeMatches);
            word.IncorrectMatches.Should().BeEquivalentTo(incorrectMatches);
        }
    }
}