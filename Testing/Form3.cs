using System;
using System.IO;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            for (int i = richTextBox1.Lines.Length + 7+10; i > richTextBox1.Lines.Length; i--)
            {
                File.WriteAllText( $@"thebreakerv{i-richTextBox1.Lines.Length-6}.mcfunction",richTextBox1.Lines[i-richTextBox1.Lines.Length+7] );
            }
        }

        private void Form3_Load( object sender, EventArgs e )
        {

        }
    }
}
