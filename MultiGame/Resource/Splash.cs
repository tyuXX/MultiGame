namespace MultiGame.Resource;

internal partial class Splash : Form
{
    internal Splash()
    {
        InitializeComponent();
        mgLogo1.until = 0;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        mainform.Hide();
        progressBar1.Value += 1;
        if (progressBar1.Value == progressBar1.Maximum)
        {
            mainform.Show();
            Close();
        }
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
        label1.Text += '.';
        if (label1.Text == ("Loading....."))
        {
            label1.Text = "Loading";
        }
    }

    private void Splash_Load(object sender, EventArgs e) => progressBar1.Maximum = Lbm;

    private void timer3_Tick(object sender, EventArgs e)
    {
        mgLogo1.until += 5;
        mgLogo1.Refresh();
    }
}
