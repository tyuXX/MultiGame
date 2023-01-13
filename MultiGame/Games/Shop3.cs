using System.Windows.Forms;

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
            if (formatnums)
            {
                button1.Text = "Auto Upgrade Interval\r\n" + FormatBigNum(autoupgradeinterval) + "ms\r\n$" + FormatBigNum(autoupgradeintervaln);
                button2.Text = "Money Bag Spawn Rate\r\n" + (300 - moneybagc) + "/300\r\n$" + FormatBigNum(moneybagcn);
                button3.Text = "Generation Boost Spawn Rate\r\n" + (600 - genboostc) + "/600\r\n$" + FormatBigNum(genboostcn);
            }
            else
            {
                button1.Text = "Auto Upgrade Interval\r\n" + autoupgradeinterval + "ms\r\n$" + autoupgradeintervaln;
                button2.Text = "Money Bag Spawn Rate\r\n" + (300 - moneybagc) + "/300\r\n$" + moneybagcn;
                button3.Text = "Generation Boost Spawn Rate\r\n" + (600 - genboostc) + "/600\r\n$" + genboostcn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upautoupgradespeed();
            updatestore3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upmoneybagc();
            updatestore3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upgenboostc();
            updatestore3();
        }

        private void Shop3_Load(object sender, EventArgs e) => updatestore3();
    }
}
