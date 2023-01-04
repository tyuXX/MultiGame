using System;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Games
{
    public partial class Shop3 : Form
    {
        public Shop3()
        {
            InitializeComponent();
        }
        private void updatestore3()
        {
            button1.Text = "Auto Upgrade Interval\r\n" + autoupgradeinterval + "ms\r\n$" + autoupgradeintervaln;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upautoupgradespeed();
            updatestore3();
        }
    }
}
