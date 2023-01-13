using System.Windows.Forms;

namespace MultiGame.Games
{
    public partial class Magic : Form
    {
        public Magic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (magicpower >= 50)
            {
                magicpower -= 50;
                Form fm = new Boosts.MoneyBag();
                fm.MdiParent = mainform;
                fm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (magicpower >= 240)
            {
                magicpower -= 240;
                Form fm = new Boosts.GenerationBoost();
                fm.MdiParent = mainform;
                fm.Show();
            }
        }

        private void Magic_FormClosing(object sender, FormClosingEventArgs e)
        {
            magicshown = false;
        }
    }
}
