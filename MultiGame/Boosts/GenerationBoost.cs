using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Boosts
{
    public partial class GenerationBoost : Form
    {
        BigInteger time = rng.Next(1, 30);
        BigInteger boosttime = rng.Next(1, 60);
        BigInteger boost = rng.Next(1, 777);
        public GenerationBoost()
        {
            InitializeComponent();
        }
        private void collect()
        {
            boost1t += boosttime;
            boost1 *= boost;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collect();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (autocollectboosts)
            {
                collect();
            }
            time--;
            if (time < 1)
            {
                this.Close();
            }
        }

        private void GenerationBoost_Load(object sender, EventArgs e)
        {
            label1.Text = "Boost:x" + boost;
            label2.Text = "Time:" + boosttime;
        }
    }
}
