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
    public partial class Clicker : Form
    {
        public Clicker()
        {
            InitializeComponent();
        }

        private void Clicker_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Clicker/Form]{(Log)}Opening Form");
        }

        private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Clicker/Form]{(Log)}Closing Form");
            clshown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += getmoney();
            xp += getmoney();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "Money:" + money;
        }
    }
}
