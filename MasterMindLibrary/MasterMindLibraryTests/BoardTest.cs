using FluentAssertions;
using FluentAssertions.Execution;
using MasterMindLibrary;
using NUnit.Framework;

namespace MasterMindLibraryTests
{
    [TestFixture]
    public class BoardTest
    {
        [TestCase("",3)]
        [TestCase("aus",3)]
        public void StartGameTest(string word, int tries)
        {
            var board = new Board(tries);
            using (new AssertionScope())
            {
                board.StartGame(word);
                board.GameStart.Should().BeTrue();
                board.OriginWord.Should().Be(word);
                board.TryList.Should().HaveCount(tries);
                foreach (var tryItem in board.TryList)
                {
                    tryItem.Word.Should().NotBeNull();
                    tryItem.Word.CorrectMatches.Should().HaveCount(word.Length);
                    tryItem.Word.IncludeMatches.Should().HaveCount(word.Length);
                    tryItem.Word.IncorrectMatches.Should().HaveCount(word.Length);
                }
            }
        }

        [Test]
        public void AddTryWorks_EmptyInput()
        {
            var board = new Board(0);
            board.StartGame("");
            using (new AssertionScope())
            {
                board.AddTry("");
                board.GameStart.Should().BeFalse();
                board.PlayerHasWon.Should().BeFalse();
                board.TriesLeft.Should().Be(0);
                board.TryList.Should().BeEmpty();
            }
        }

        [TestCase("aus","lor", 2, new[] { false, false, false }, new[] { false, false, false }, new[] { true, true, true },true, null)]
        [TestCase("aus","usa", 2, new[] { false, false, false }, new[] { true, true, true}, new[] { true, true, true }, true, null)]
        [TestCase("aus","aus", 2, new[] { true, true, true}, new[] { true, true, true}, new[] { false, false, false}, false, true)]
        public void AddTryWorks(string originWord, string word, int tries, bool[] correctMatches, bool[] includeMatches, bool[] incorrectMatches, bool gameStart, bool? playerWon)
        {
            var board = new Board(tries);
            board.StartGame(originWord);
            using (new AssertionScope())
            {
                board.AddTry(word);
                board.GameStart.Should().Be(gameStart);
                board.PlayerHasWon.Should().Be(playerWon);
                board.OriginWord.Should().Be(originWord);
                board.TriesLeft.Should().Be(tries - 1);
                for (var index = 0; index < board.TryList.Count; index++)
                {
                    var tryItem = board.TryList[index];
                    if(index == 0)
                    {
                        tryItem.Word.CorrectMatches.Should().BeEquivalentTo(correctMatches);
                        tryItem.Word.IncludeMatches.Should().BeEquivalentTo(includeMatches);
                        tryItem.Word.IncorrectMatches.Should().BeEquivalentTo(incorrectMatches);
                    }
                    else
                    {
                        tryItem.Word.CorrectMatches.Should().OnlyContain(c => c == false);
                        tryItem.Word.IncludeMatches.Should().OnlyContain(c => c == false);
                        tryItem.Word.IncorrectMatches.Should().OnlyContain(c => c == false);
                    }
                    tryItem.Used.Should().Be(index == 0);
                }
            }
        }
    }
}