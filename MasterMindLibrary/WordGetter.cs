namespace MasterMindLibrary
{
    public static class WordGetter
    {
        private static Random? _random;
        private static StringReader? _builder;
        private static string _wordList;
        private static IList<string> _lines;

        public static void SetUp()
        {
            _random = new Random();
            var stream = new StreamReader("wortliste.txt");
            _builder = new StringReader(stream.ReadToEnd());
            _wordList = _builder.ReadToEnd();
            _lines = _wordList.Replace("\r", "").Split('\n').Select(l => l.ToUpper()).ToList();
            stream.Close();
        }

        public static string GetRandomWord(int? letterCount = null)
        {
            var lines = _lines.ToList();
            if (letterCount != null)
                lines = lines.Where(l => l.Length == letterCount).ToList();
            if (_random == null) return string.Empty;
            var index = _random.Next(-1, lines.Count);
            return lines.Count >= index ? lines[index] : string.Empty;

        }

        public static bool WordExists(string word)
        {
            return _lines.Contains(word);
        }
    }
}
