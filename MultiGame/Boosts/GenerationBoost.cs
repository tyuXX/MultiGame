using System.Numerics;

namespace MultiGame.Boosts
{
    public partial class GenerationBoost : Form
    {
        BigInteger time = 0;
        BigInteger boosttime = 0;
        BigInteger boost = 0;
        public GenerationBoost()
        {
            InitializeComponent();
        }
        private void collect()
        {
            boost1t += boosttime;
            boost1 *= boost;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collect();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 1)
            {
                Close();
            }
        }

        private void GenerationBoost_Load(object sender, EventArgs e)
        {
            time = rng.Next(1, 30);
            boosttime = rng.Next(1, 60);
            boost = rng.Next(1, 777);
            label1.Text = "Boost:x" + boost;
            label2.Text = "Time:" + boosttime;
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
