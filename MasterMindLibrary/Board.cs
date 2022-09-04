namespace MasterMindLibrary
{
    public class Board
    {
        private readonly int _tries;
        private int tryCount;
        public string OriginWord { get; private set; }
        public int TriesLeft { get; private set; }
        public List<Try> TryList { get; private set; }
        public bool GameStart { get; private set; }
        public bool? PlayerHasWon { get; private set; }

        public Board(int tries)
        {
            _tries = tries;
            TriesLeft = tries;
        }

        public void StartGame(string word)
        {
            OriginWord = word;
            GameStart = true;
            TryList = new List<Try>();
            for (var i = 0; i < _tries; i++)
            {
                TryList.Add(new Try
                {
                    Word = CreateWord(word)
                });   
            }
        }

        public void AddTry(string word)
        {
            if (TriesLeft - 1 < 0)
            {
                GameStart = false;
                PlayerHasWon = false;
                return;
            }
            var tryItem = TryList[tryCount];
            if (OriginWord.Equals(word))
            {
                PlayerHasWon = true;
                GameStart = false;
            }
            for (var i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                tryItem.Word.Match(letter, i, OriginWord);
            }

            tryItem.Word.TryWord = word;
            tryItem.Used = true;
            TriesLeft--;
            tryCount++;
            if (TriesLeft > 0) return;
            GameStart = false;
            PlayerHasWon = false;
        }

        private Word CreateWord(string word)
        {
            return new Word
            {
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