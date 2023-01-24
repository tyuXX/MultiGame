namespace MultiGame.Tools
{
    public partial class Variables : Form
    {
        public Variables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => refresh();

        private void refresh()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            button2.Text = $"Auto Refresh\r\n{timer1.Enabled}";
        }

        private void timer1_Tick(object sender, EventArgs e) => refresh();

        private void Variables_FormClosing(object sender, FormClosingEventArgs e) => varsshown = false;

        private void Variables_Load(object sender, EventArgs e)
        {

        }
    }
}
