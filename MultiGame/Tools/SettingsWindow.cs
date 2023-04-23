namespace MultiGame.Tools;

public partial class SettingsWindow : Form
{
    public SettingsWindow()
    {
        InitializeComponent();
    }

    private void sButton1_CheckedChanged(object sender, EventArgs e) => alwaysontop = sButton1.Checked;

    private void sButton2_CheckedChanged(object sender, EventArgs e) => messagesend = sButton2.Checked;

    private void sButton3_CheckedChanged(object sender, EventArgs e) => formatnums = sButton3.Checked;

    private void sButton4_CheckedChanged(object sender, EventArgs e) => formatranks = sButton4.Checked;

    private void sButton5_CheckedChanged(object sender, EventArgs e) => maxbuy = sButton5.Checked;

    private void SettingsWindow_Load(object sender, EventArgs e)
    {
        sButton1.Checked = alwaysontop;
        sButton2.Checked = messagesend;
        sButton3.Checked = formatnums;
        sButton4.Checked = formatranks;
        sButton5.Checked = maxbuy;
    }

    private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e) => settingswindowshown = false;
}
