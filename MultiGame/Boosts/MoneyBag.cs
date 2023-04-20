using System.Numerics;

namespace MultiGame.Boosts;

internal partial class MoneyBag : Form
{
    BigInteger time = 0;
    BigInteger gift = 0;
    internal MoneyBag()
    {
        InitializeComponent();
    }

    private void tick_Tick(object sender, EventArgs e)
    {
        time--;
        if (time < 1)
        {
            Close();
        }
    }
    private void collect()
    {
        money += gift;
        xp += gift;
        Close();
    }
    private void button1_Click(object sender, EventArgs e) => collect();

    private void MoneyBag_Load(object sender, EventArgs e)
    {
        time = rng.Next(1, 30);
        gift = rng.Next(1, 30000) * getmoney;
        label1.Text = "Money:" + gift;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (autocollectboosts)
        {
            timer1.Enabled = false;
            collect();
        }
    }
}
