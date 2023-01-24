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

        private void Log_FormClosing(object sender, FormClosingEventArgs e) => logshown = false;

        private void Log_Load(object sender, EventArgs e)
        {

        }
    }
}
