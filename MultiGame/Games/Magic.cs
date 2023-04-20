namespace MultiGame.Games;

internal partial class Magic : Form
{
    internal Magic()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (magicpower >= 50)
        {
            magicpower -= 50;
            Form fm = new Boosts.MoneyBag
            {
                MdiParent = mainform
            };
            fm.Show();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (magicpower >= 240)
        {
            magicpower -= 240;
            Form fm = new Boosts.GenerationBoost
            {
                MdiParent = mainform
            };
            fm.Show();
        }
    }

    private void Magic_FormClosing(object sender, FormClosingEventArgs e) => magicshown = false;

    private void Magic_Load(object sender, EventArgs e)
    {

    }
}
