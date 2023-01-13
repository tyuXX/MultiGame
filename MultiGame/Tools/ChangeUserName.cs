using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class ChangeUserName : Form
    {
        public ChangeUserName()
        {
            InitializeComponent();
        }

        private void ChangeUserName_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/ChangeUserName/Form]{(Log)}Closing Form");
            changeusernameshown = false;
        }

        private void ChangeUserName_Load(object sender, EventArgs e) => log.Add("[" + DateTime.Now + "][From:Internal/Tool/ChangeUserName/Form]{(Log)}Opening Form");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == endecode)
            {
                username = textBox2.Text;
                this.Close();
            }
        }
    }
}
