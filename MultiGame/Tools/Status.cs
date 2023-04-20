namespace MultiGame.Tools;

internal partial class Status : Form
{
    internal Status()
    {
        InitializeComponent();
    }
    private void refreshs()
    {
        label1.Text = $"Name:{username}";
        label2.Text = $"PassCode:{endecode}";
        label4.Text = $"Total Clicks:{totalclicks}";
        label5.Text = $"Direct Total Clicks:{totalclicksdirect}";
        label6.Text = $"Total Time Spent:{timespent}";
        if (formatnums)
        {
            label3.Text = $"Money:{FormatBigNum(money)}";
            label7.Text = $"Level:{FormatBigNum(level)}";
        }
        else
        {
            label3.Text = $"Money:{money}";
            label7.Text = $"Level:{level}";
        }
        if (formatranks)
        {
            label8.Text = $"Rank:{RankCalc(rank)}";
            label9.Text = $"Rebirth:{RankCalc(rebirth)}";
        }
        else
        {
            label8.Text = $"Rank:{rank}";
            label9.Text = $"Rebirth:{rebirth}";
        }
    }

    private void Status_Load(object sender, EventArgs e) => refreshs();

    private void refresh_Tick(object sender, EventArgs e) => refreshs();

    private void Status_FormClosing(object sender, FormClosingEventArgs e) => statusopen = false;
}
