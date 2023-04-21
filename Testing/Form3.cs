using System;
using System.IO;
using System.Text;
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
            richTextBox2.Text = BoolArrayToString(StringToBoolArray( richTextBox1.Text, ',' ));
        }
        internal static string BoolArrayToString( bool[] array )
        {
            StringBuilder sb = new StringBuilder();
            foreach (bool bol in array)
            {
                sb.Append( bol.ToString() );
                sb.Append( ',' );
            }
            return sb.ToString();
        }
        internal static bool[] StringToBoolArray( string str, char split )
        {
            string[] array = str.Split( split );
            bool[] barray = new bool[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                barray[i] = bool.Parse( array[i] );
            }
            return barray;
        }

        private void Form3_Load( object sender, EventArgs e )
        {

        }
    }
}
