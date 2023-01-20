using System.Drawing;

namespace MultiGame.Games
{
    public partial class Shop4 : Form
    {
        public Shop4()
        {
            InitializeComponent();
        }
        private void updatestore4()
        {
            if (formatnums)
            {
                button1.Text = "Automatic RankUp\r\n$" + FormatBigNum(exponent(10, 998));
                button2.Text = "Automatic Rebirth\r\n$" + FormatBigNum(exponent(10, 1300));
            }
            else
            {
                button1.Text = "Automatic RankUp\r\n$" + exponent(10, 998);
                button2.Text = "Automatic Rebirth\r\n$" + exponent(10, 1300);
            }
            if (automaticrank)
            {
                button1.Enabled = false;
                button1.BackColor = Color.Gray;
                button1.ForeColor = Color.Gray;
            }
            if (automaticrebirth)
            {
                button2.Enabled = false;
                button2.BackColor = Color.Gray;
                button2.ForeColor = Color.Gray;
            }
        }

        private void Shop4_Load(object sender, EventArgs e)
        {
            updatestore4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (money >= exponent(10, 998))
            {
                money -= exponent(10, 998);
                automaticrank = true;
                updatestore4();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= exponent(10, 1300))
            {
                money -= exponent(10, 1300);
                automaticrebirth = true;
                updatestore4();
            }
        }

        private void Shop4_FormClosing(object sender, FormClosingEventArgs e)
        {
            shop4shown = false;
        }
    }
}
