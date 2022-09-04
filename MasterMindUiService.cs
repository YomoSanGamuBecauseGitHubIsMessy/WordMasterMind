using System;
using MasterMindLibrary;

namespace MasterMind
{
    internal class MasterMindUiService
    {
        private Board? _board;
        private Panel _gamePanel;

        public MasterMindUiService(Panel gamePanel)
        {
            _gamePanel = gamePanel;
        }
        public Label CreateLabel(char letter, Match match)
        {
            Color color;
            switch (match)
            {
                case Match.NoMatch:
                    color = Color.Gray;
                    break;
                case Match.Include:
                    color = Color.Orange;
                    break;
                case Match.Match:
                    color = Color.Green;
                    break;
                case Match.Nothing:
                    color = Color.White;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(match), match, null);
            }

            var font = new Font("Times New Roman", 12.0f);
            return new Label
            {
                Name = $"lttr_{letter}_{Guid.NewGuid()}",
                Size = new Size(40, 40),
                AutoSize = false,
                BackColor = color,
                Text = match == Match.Nothing ? string.Empty : $@"{letter}",
                Font = font,
                Padding = new Padding(0,0,0,10)
            };
        }

        public void EnterWord(string word)
        {
            if(_board == null) return;
            if (_board.OriginWord.Length != word.Length)
            {
                MessageBoxCreator.Show("Das Wort muss genauso lang sein, wie das Suchwort!");
                return;
            }

            if (!WordGetter.WordExists(word.ToUpper()))
            {
                MessageBoxCreator.Show("Das Wort existiert nicht!");
                return;
            }
            _board.AddTry(word.ToUpper());
            UpdateGamePanel();

            if (_board.GameStart) return;
            if(!_board.PlayerHasWon.HasValue) return;
            MessageBoxCreator.Show(_board.PlayerHasWon.Value ? "Du hast gewonnen!" : "Leider verloren! :(");
            _board = null;
        }

        public void StartGame()
        {
            var randomWord = WordGetter.GetRandomWord(5);
            _board = new Board(7);
            _board.StartGame(randomWord.ToUpper());
            UpdateGamePanel();
        }

        public void UpdateGamePanel()
        {
            _gamePanel.Controls.Clear();
            for (var index = 0; index < _board.TryList.Count; index++)
            {
                var tryItem = _board.TryList[index];
                var length = _board.OriginWord.Length;
                var flowPanel = new FlowLayoutPanel
                {
                    Name = $"line{index}",
                    //AutoSize = true,
                    Width = _gamePanel.Width
                };
                for (var i = 0; i < length; i++)
                {
                    var match = tryItem.GetMatch(i);
                    var panel = CreateLabel(tryItem.Word.TryWord == null ? '_' :tryItem.Word.TryWord[i], match);
                    flowPanel.Controls.Add(panel);
                }

                _gamePanel.Controls.Add(flowPanel);
            }
        }
    }
}
