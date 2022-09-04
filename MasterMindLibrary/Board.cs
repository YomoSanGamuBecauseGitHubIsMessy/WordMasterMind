namespace MasterMindLibrary
{
    public class Board
    {
        private readonly int _tries;
        private int _tryCount;
        public string OriginWord { get; private set; }
        public int TriesLeft { get; private set; }
        public List<Try> TryList { get; private set; }
        public bool GameStart { get; private set; }
        public bool? PlayerHasWon { get; private set; }
        public Dictionary<char, int> DoubleLetters { get; set; }
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
            DoubleLetters = BuildDoubleLetters(word);
            for (var i = 0; i < _tries; i++)
            {
                TryList.Add(new Try
                {
                    CorrectMatches = CreateMatches(word.Length),
                    IncludeMatches = CreateMatches(word.Length),
                    IncorrectMatches = CreateMatches(word.Length)
                });   
            }
        }

        private Dictionary<char, int> BuildDoubleLetters(string word)
        {
            var letters = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (letters.ContainsKey(letter))
                    letters[letter]++;
                else letters.Add(letter, 1);
            }

            return letters;
        }

        public void AddTry(string word)
        {
            if (TriesLeft - 1 < 0)
            {
                GameStart = false;
                PlayerHasWon = false;
                return;
            }

            if (OriginWord.Equals(word))
            {
                PlayerHasWon = true;
                GameStart = false;
            }

            var tryItem = TryList[_tryCount];
            var doubleLetters = BuildDoubleLetters(word);

            for (var i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                tryItem.MatchLetter(letter, i, OriginWord, doubleLetters);
            }

            tryItem.TryWord = word;
            tryItem.Used = true;
            TriesLeft--;
            _tryCount++;
            if (TriesLeft > 0) return;
            GameStart = false;
            PlayerHasWon = false;
        }

        private bool[] CreateMatches(int wordLength)
        {
            return new bool[wordLength];
        }
    }
}