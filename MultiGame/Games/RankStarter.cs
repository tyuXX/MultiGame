namespace MultiGame.Games;

internal partial class RankStarter : Form
{
    internal RankStarter()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if ((!shop5shown) && ((rank >= 9) || (rebirth >= 9)))
        {
            shop5shown = true;
            Shop5 shop5 = new Shop5
            {
                MdiParent = mainform
            };
            shop5.Show();
        }
    }

    private void RankStarter_FormClosing(object sender, FormClosingEventArgs e) => rankstartershown = false;
}
