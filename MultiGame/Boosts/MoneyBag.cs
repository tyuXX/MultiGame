using System;
using System.Numerics;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Boosts
{
    public partial class MoneyBag : Form
    {
        BigInteger time = 0;
        BigInteger gift = 0;
        public MoneyBag()
        {
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 1)
            {
                this.Close();
            }
        }
        private void collect()
        {
            money += gift;
            xp += gift;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            collect();
        }

        private void MoneyBag_Load(object sender, EventArgs e)
        {
            time = rng.Next(1, 30);
            gift = rng.Next(1, 30000) * getmoney();
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
}
