using System.Drawing;

namespace MultiGame.Games;

internal partial class Shop2 : Form
{
    internal Shop2()
    {
        InitializeComponent();
    }
    private void updatestore2()
    {
        if (formatnums)
        {
            button1.Text = "Auto Upgrade $" + FormatBigNum(exponent(10, 20));
            button2.Text = "Auto Collect $" + FormatBigNum(exponent(10, 30));
        }
        else
        {
            button1.Text = "Auto Upgrade $" + exponent(10, 20);
            button2.Text = "Auto Collect $" + exponent(10, 30);
        }
        if (automaticupgrade)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Gray;
        }
        if (autocollectboosts)
        {
            button2.Enabled = false;
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.Gray;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (money >= exponent(10, 20))
        {
            money -= exponent(10, 20);
            automaticupgrade = true;
            updatestore2();
        }
    }

    private void Shop2_Load(object sender, EventArgs e)
    {
        update.Enabled = Autoupdateshops;
        updatestore2();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (money >= exponent(10, 30))
        {
            money -= exponent(10, 30);
            autocollectboosts = true;
            updatestore2();
        }
    }

    private void Shop2_FormClosing(object sender, FormClosingEventArgs e) => shop2shown = false;

    private void update_Tick(object sender, EventArgs e) => updatestore2();
}
