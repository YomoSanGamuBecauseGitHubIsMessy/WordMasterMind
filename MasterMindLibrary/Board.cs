namespace MasterMindLibrary
{
    public class Board
    {
        private readonly int _tries;
        public int TriesLeft { get; private set; }
        public List<Try> TrieList { get; private set; }
        public bool GameStart { get; private set; }
        public bool? PlayerHasWon { get; private set; }

        public Board(int tries)
        {
            _tries = tries;
            TriesLeft = tries;
        }

        public void StartGame(string word)
        {
            GameStart = true;
            TrieList = new List<Try>();
            for (var i = 0; i < _tries; i++)
            {
                TrieList.Add(new Try
                {
                    Word = CreateWord(word)
                });   
            }
        }

        public void AddTry(string word)
        {
            var tryIndex = TriesLeft - 1;
            if (tryIndex == 0)
            {
                GameStart = false;
                PlayerHasWon = false;
            }
            else
            {
                var tryItem = TrieList[tryIndex];
                if (tryItem.Word.Match(word))
                {
                    PlayerHasWon = true;
                    GameStart = false;
                }
                else
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        var letter = word[i];
                        tryItem.Word.Match(letter, i);
                    }
                }
                tryItem.Used = true;
                TriesLeft--;
            }
        }

        private Word CreateWord(string word)
        {
            return new Word
            {
                OriginWord = word,
                CorrectMatches = CreateMatches(word.Length),
                IncludeMatches = CreateMatches(word.Length),
                IncorrectMatches = CreateMatches(word.Length)
            };
        }

        private bool[] CreateMatches(int wordLength)
        {
            return new bool[wordLength];
        }
    }
}