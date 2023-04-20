namespace MultiGame.Tools;

internal partial class ToggleDevMode : Form
{
    internal ToggleDevMode()
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
                Close();
            }
            else
            {
                textBox1.Text = "Unknown PassCode";
            }
        }
    }

    private void ToggleDevMode_FormClosing(object sender, FormClosingEventArgs e) => toggledevmodeshown = false;

    private void ToggleDevMode_Load(object sender, EventArgs e)
    {

    }
}
