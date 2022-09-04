using FluentAssertions;
using FluentAssertions.Execution;
using MasterMindLibrary;
using NUnit.Framework;

namespace MasterMindLibraryTests;

[TestFixture]
public class TryTest : TestBase
{
    [TestCase(Match.Nothing, new[] { false }, new[] { false}, new[] { false})]
    [TestCase(Match.Match, new[] { true}, new[] { false}, new[] { false})]
    [TestCase(Match.Include, new[] { false}, new[] { true}, new[] { false})]
    [TestCase(Match.NoMatch, new[] { false}, new[] { false}, new[] { true})]
    public void GetMatchWorks(Match expectedMatch,bool[] correctMatches, bool[] includeMatches, bool[] incorrectMatches)
    {
        var tryItem = new Try
        {
            Word = new Word
            {
                CorrectMatches = correctMatches,
                IncludeMatches = includeMatches,
                IncorrectMatches = incorrectMatches
            }
        };
        using (new AssertionScope())
        {
            tryItem.GetMatch(0).Should().Be(expectedMatch);
        }
    }
}