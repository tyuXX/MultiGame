namespace MultiGame.Tools;

internal partial class ChangeUserName : Form
{
    internal ChangeUserName()
    {
        InitializeComponent();
    }

    private void ChangeUserName_FormClosing(object sender, FormClosingEventArgs e) => changeusernameshown = false;

    private void ChangeUserName_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == endecode)
        {
            username = textBox2.Text;
            Close();
        }
    }
}
