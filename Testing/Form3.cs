using System;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string s in richTextBox1.Lines)
            {
                string sc = "{" + s + "}";
                richTextBox2.Text += $"{s}:{sc}\r\n";
            }
        }
    }
}
