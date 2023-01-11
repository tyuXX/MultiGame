using System;
using System.Numerics;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        BigInteger money = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money++;
            label1.Text = "Money:" + money;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visualizer1.TestShowVisualizer(money);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("nice try", this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            money++;
            label1.Text = "Money:" + money;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabControl1.TabPages.Add(tabPage);
        }
    }
}
