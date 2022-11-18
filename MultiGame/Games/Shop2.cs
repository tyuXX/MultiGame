using MultiGame.Boosts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Games
{
    public partial class Shop2 : Form
    {
        public Shop2()
        {
            InitializeComponent();
        }
        private void updatestore2()
        {
            button1.Text = "Auto Upgrade $" + exponent(10, 20);
            button1.Text = "Auto Collect $" + exponent(10, 30);
            button1.Enabled = !automaticupgrade;
            button2.Enabled = !autocollectboosts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(money >= exponent(10,20)) 
            {
                money -= exponent(10, 20);
                automaticupgrade = true;
            }
        }

        private void Shop2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= exponent(10, 30))
            {
                money -= exponent(10, 30);
                autocollectboosts = true;
            }
        }

        private void Shop2_FormClosing(object sender, FormClosingEventArgs e)
        {
            shop2shown = false;
        }
    }
}
