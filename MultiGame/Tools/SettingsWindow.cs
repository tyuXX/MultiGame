namespace MultiGame.Tools;

internal partial class SettingsWindow : Form
{
    internal SettingsWindow()
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
        sButton6.Checked = autoclicktoggle;
        sButton7.Checked = autoupgradetoggle;
    }

    private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e) => settingswindowshown = false;

    private void sButton6_CheckedChanged(object sender, EventArgs e)
    {
        autoclicktoggle = sButton6.Checked;
    }

    private void sButton7_CheckedChanged(object sender, EventArgs e)
    {
        autoupgradetoggle = sButton6.Checked;
    }
}
