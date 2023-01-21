namespace MultiGame.Games
{
    public partial class Shop5 : Form
    {
        public Shop5()
        {
            InitializeComponent();
        }
        private void updateshop5()
        {
            if (formatnums)
            {
                button1.Text = "LevelUp Speed " + FormatBigNum(levelupmultu.value) + "\r\n$" + FormatBigNum(levelupmultu.cache);
            }
            else
            {
                button1.Text = "LevelUp Speed " + levelupmultu.value + "\r\n$" + levelupmultu.cache;
            }
        }

        private void Shop5_Load(object sender, EventArgs e)
        {
            update.Enabled = Autoupdateshops;
            updateshop5();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateshop5();
            uplevelupmult();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            updateshop5();
        }

        private void Shop5_FormClosing(object sender, FormClosingEventArgs e)
        {
            shop5shown = false;
        }
    }
}
