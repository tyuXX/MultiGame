namespace MultiGame.Games
{
    public partial class MagicPowerGenerator : Form
    {
        public MagicPowerGenerator()
        {
            InitializeComponent();
        }

        private void MagicPowerGenerator_Load(object sender, EventArgs e) => updatestoresc();

        private void updatestoresc()
        {
            if (formatnums)
            {
                button1.Text = "Create Magic Power $" + FormatBigNum(1000 * getmoney);
            }
            else
            {
                button1.Text = "Create Magic Power $" + (1000 * getmoney);
            }
        }

        private void MagicPowerGenerator_FormClosing(object sender, FormClosingEventArgs e) => magicpowergeneratorshown = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (maxbuy)
            {
                while (money >= (magicpower * 1000 * getmoney))
                {
                    magicpower++;
                    money -= magicpower * 1000 * getmoney;
                    updatestoresc();
                }
            }
            else
            {
                if (money >= (magicpower * 1000 * getmoney))
                {
                    magicpower++;
                    money -= magicpower * 1000 * getmoney;
                    updatestoresc();
                }
            }
        }
    }
}
