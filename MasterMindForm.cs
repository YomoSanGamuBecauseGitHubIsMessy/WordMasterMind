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
            _service = new MasterMindUiService(GamePanel);
        }

        private void wordTxtBx_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter) return;
            enterBtn_Click(sender, e);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _service.EnterWord(wordTxtBx.Text);
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
                _service.StartGame();
            }
            catch (Exception exception)
            {
                Log(exception);
            }
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