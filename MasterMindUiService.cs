using MasterMindLibrary;

namespace MasterMind
{
    internal class MasterMindUiService
    {
        private Board? _board;
        private Panel _gamePanel;
        private Panel _lettersPanel;

        public MasterMindUiService(Panel gamePanel, Panel lettersPanel)
        {
            _gamePanel = gamePanel;
            _lettersPanel = lettersPanel;
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
                Padding = new Padding(0,0,0,10),
                BorderStyle = BorderStyle.FixedSingle
            };
        }
        private void wordTxtBx_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender is not TextBox box) return;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Delete && e.KeyCode != Keys.Back)
            {
                box.Text = box.Text.Length > 0 ? box.Text[..1] : box.Text;
                var index = _lettersPanel.Controls.IndexOf(box);
                if (index - 1 < _lettersPanel.Controls.Count && index - 1 > -1)
                    _lettersPanel.Controls[index - 1].Focus();
                return;
            }

            if (e.KeyCode != Keys.Enter) return;
            EnterWord();
        }
        public void EnterWord()
        {
            if(_board == null) return;
            var word = string.Empty;
            var controls = _lettersPanel.Controls;
            for (var index = controls.Count - 1; index >= 0; index--)
            {
                var box = (TextBox) controls[index];
                word += box.Text;
                box.Text = string.Empty;
            }

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
            MessageBoxCreator.Show(_board.PlayerHasWon.Value ? "Du hast gewonnen!" : $@"Leider verloren! :(
Das gesuchte Wort war {_board.OriginWord}");
            _board = null;
        }

        public void StartGame(int letterCount, int tries)
        {
            var randomWord = WordGetter.GetRandomWord(letterCount);
            _board = new Board(tries);
            _board.StartGame(randomWord.ToUpper());
            UpdateGamePanel();
            UpdateLettersPanel(randomWord);
        }

        private void UpdateLettersPanel(string randomWord)
        {
            _lettersPanel.Controls.Clear();
            for (var index = randomWord.Length - 1; index >= 0; index--)
            {
                var letter = randomWord[index];
                var textBox = new TextBox
                {
                    Name = $"txtBx_{letter}_{Guid.NewGuid()}",
                    Size = new Size(23, 23),
                    TabIndex = index
                };
                textBox.KeyDown += wordTxtBx_KeyDown;
                _lettersPanel.Controls.Add(textBox);
            }
        }

        public void UpdateGamePanel()
        {
            _gamePanel.Controls.Clear();
            if (_board == null) return;
            for (var index = 0; index < _board.TryList.Count; index++)
            {
                var label = new Label
                {
                    Name = $"countLbl{index}",
                    Text = $@"{index + 1}. Versuch"
                };
                var tryItem = _board.TryList[index];
                var length = _board.OriginWord.Length;
                var flowPanel = new FlowLayoutPanel
                {
                    Name = $"line{index}",
                    Width = _gamePanel.Width - 25,
                    Padding = new Padding(0,0,0,5)
                };
                for (var i = 0; i < length; i++)
                {
                    var match = tryItem.GetMatch(i);
                    var panel = CreateLabel(tryItem.TryWord == null ? '_' : tryItem.TryWord[i], match);
                    flowPanel.Controls.Add(panel);
                }
                _gamePanel.Controls.Add(label);
                _gamePanel.Controls.Add(flowPanel);
            }
        }
    }
}
