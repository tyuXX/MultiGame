namespace MultiGame.Tools
{
    public partial class Message : Form
    {
        internal short life = 10;
        public Message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private void tick_Tick(object sender, EventArgs e)
        {
            if (life > 0)
            {
                life--;
            }
            else
            {
                Close();
            }
        }
    }
}
