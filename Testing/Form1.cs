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
    }
}
