using System;
using System.Drawing;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Tools
{
    public partial class Advancements1 : Form
    {
        public Advancements1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Advancements1_Load(object sender, EventArgs e)
        {
            if (!advance[ 1 ])
            {
                button2.BackColor = Color.Gray;
            }
            if (!advance[ 2 ])
            {
                button3.BackColor = Color.Gray;
            }
            if (!advance[ 3 ])
            {
                button4.BackColor = Color.Gray;
            }
            if (!advance[ 4 ])
            {
                button5.BackColor = Color.Gray;
            }
            if (!advance[ 5 ])
            {
                button6.BackColor = Color.Gray;
            }
            if (!advance[ 6 ])
            {
                button7.BackColor = Color.Gray;
            }
            if (!advance[ 7 ])
            {
                button8.BackColor = Color.Gray;
            }
            if (!advance[ 8 ])
            {
                button9.BackColor = Color.Gray;
            }
            if (!advance[ 9 ])
            {
                button10.BackColor = Color.Gray;
            }
            if (!advance[ 10 ])
            {
                button11.BackColor = Color.Gray;
            }
            if (!advance[ 11 ])
            {
                button12.BackColor = Color.Gray;
            }
            if (!advance[ 12 ])
            {
                button13.BackColor = Color.Gray;
            }
            if (!advance[ 13 ])
            {
                button14.BackColor = Color.Gray;
            }
            if (!advance[ 14 ])
            {
                button15.BackColor = Color.Gray;
            }
            if (!advance[ 15 ])
            {
                button16.BackColor = Color.Gray;
            }
            if (!advance[ 16 ])
            {
                button17.BackColor = Color.Gray;
            }
            if (!advance[ 17 ])
            {
                button18.BackColor = Color.Gray;
            }
            if (!advance[ 18 ])
            {
                button19.BackColor = Color.Gray;
            }
        }
    }
}
