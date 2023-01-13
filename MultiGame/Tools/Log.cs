using System.Threading;
using System.Windows.Forms;

namespace MultiGame.Tools
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        private void loadlog()
        {
            timer1.Interval = logupdateinterval;
            foreach (string str in log)
            {
                richTextBox1.Text += str + "\n";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Thread th = new Thread(loadlog);
            th.Start();
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/Log/Form]{(Log)}Closing Form");
            logshown = false;
        }

        private void Log_Load(object sender, EventArgs e) => log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/Log/Form]{(Log)}Opening Form");
    }
}
