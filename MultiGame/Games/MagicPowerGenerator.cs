using System;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Games
{
    public partial class MagicPowerGenerator : Form
    {
        public MagicPowerGenerator()
        {
            InitializeComponent();
        }

        private void MagicPowerGenerator_Load(object sender, EventArgs e)
        {
            updatestoresc();
        }
        private void updatestoresc()
        {
            button1.Text = "Create Magic Power $" + (1000*getmoney());
        }

        private void MagicPowerGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            magicpowergeneratorshown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(money >= (1000 * getmoney()))
            {
                magicpower++;
                money -= 1000 * getmoney();
                updatestoresc();
            }
        }
    }
}
