using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class ChangePassCode : Form
    {
        public ChangePassCode()
        {
            InitializeComponent();
        }

        private void ChangePassCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/ChangePassCode/Form]{(Log)}Closing Form");
            changepasscodeshown = false;
        }

        private void ChangePassCode_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/ChangePassCode/Form]{(Log)}Opening Form");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == endecode)
            {
                endecode = textBox2.Text;
                this.Close();
            }
        }
    }
}
