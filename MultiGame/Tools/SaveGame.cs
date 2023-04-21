namespace MultiGame.Tools;

internal partial class SaveGame : Form
{
    internal SaveGame()
    {
        InitializeComponent();
    }

    private void SaveGame_Load(object sender, EventArgs e)
    {

    }

    private void SaveGame_FormClosing(object sender, FormClosingEventArgs e) => savegameshown = false;

    private void button1_Click(object sender, EventArgs e)
    {
        ToggleTickers();
        savefiledia.Title = "Save Game File For MultiGame";
        savefiledia.AddExtension = true;
        savefiledia.DefaultExt = ".mgs";
        if (savefiledia.ShowDialog() == DialogResult.OK)
        {
            textBox1.Text = savefiledia.FileName;
        }
        ToggleTickers();
    }

    private void button2_Click(object sender, EventArgs e) => savegame(textBox1.Text, this);
}
