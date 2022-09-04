using log4net;

namespace MasterMind
{
    public partial class MasterMindForm : Form
    {
        private readonly MasterMindUiService _service;
        private readonly ILog _log;
        
        public MasterMindForm(ILog log)
        {
            _log = log;
            InitializeComponent();
            _service = new MasterMindUiService(GamePanel, lettersPanel);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.EnterWord();
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.StartGame(GetLetterCount(), GetTryCount());
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        private int GetTryCount()
        {
            return GetValidNumber(tryTxtBx.Text, 7);
        }

        private int GetLetterCount()
        {
            return GetValidNumber(letterCountTxtBx.Text, 5);
        }

        private int GetValidNumber(string text, int defaultNumber)
        {
            if (string.IsNullOrEmpty(text)) return defaultNumber;
            return int.TryParse(text, out var result) ? result : defaultNumber;
        }

        private void MasterMindForm_Resize(object sender, EventArgs e)
        {
            try
            {
                _service.UpdateGamePanel();
            }
            catch (Exception exception)
            {
                Log(exception);
            }
        }

        private void Log(Exception exception)
        {
            _log.Error(exception);
            MessageBoxCreator.ShowError();
        }
    }
}