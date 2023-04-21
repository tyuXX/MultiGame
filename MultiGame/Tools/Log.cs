namespace MultiGame.Tools;

internal partial class Log : Form
{
    internal Log()
    {
        InitializeComponent();
    }
    private void loadlog(List<string> log)
    {
        timer1.Interval = logupdateinterval;
        foreach (string str in log)
        {
            richTextBox1.Text += str + "\n";
        }
    }

    private void timer1_Tick(object sender, EventArgs e) => richTextBox1.Clear();

    private void Log_FormClosing(object sender, FormClosingEventArgs e) => logshown = false;

    private void Log_Load(object sender, EventArgs e)
    {

    }
}
