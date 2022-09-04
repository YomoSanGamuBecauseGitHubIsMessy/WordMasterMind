namespace MasterMind;

public static class MessageBoxCreator
{
    public static void ShowError()
    {
        MessageBox.Show(@"Ein Fehler ist aufgetreten!", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void Show(string message)
    {
        MessageBox.Show(message, @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}