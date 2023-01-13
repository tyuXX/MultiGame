using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class ToggleDevMode : Form
    {
        public ToggleDevMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string str in passcodes)
            {
                if (str == textBox1.Text)
                {
                    if (devmode)
                    {
                        devmode = false;
                    }
                    else
                    {
                        devmode = true;
                    }
                    log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/PassCode]{(Log)}Logged In with PassCode:" + str);
                    this.Close();
                }
                else
                {
                    textBox1.Text = "Unknown PassCode";
                }
            }
        }

        private void ToggleDevMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            toggledevmodeshown = false;
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/Form]{(Log)}Closing Form");
        }

        private void ToggleDevMode_Load(object sender, EventArgs e) => log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/Form]{(Log)}Opening Form");
    }
}
