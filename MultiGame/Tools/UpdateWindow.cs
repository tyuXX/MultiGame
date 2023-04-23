namespace MultiGame.Tools;

public partial class UpdateWindow : Form
{
    string newver = "N/A";
    bool ready = false;
    public UpdateWindow()
    {
        InitializeComponent();
    }

    private void UpdateWindow_Load(object sender, EventArgs e) => refresh();
    void refresh()
    {
        try
        {
            download("https://github.com/tyuXX/MultiGame/raw/master/MultiGame/update.txt", "update.txt");
            Thread.Sleep(1000);
            newver = File.ReadAllText(@".\update.txt");
            if (newver != Updatev)
            {
                ready = true;
            }
            File.Delete(@".\update.txt");
        }
        catch (Exception ex)
        {
            NewMessageWindow("Error", ex.Message, 25);
        }
        label1.Text = "Current Version:" + Updatev;
        label2.Text = "New Version:" + newver;
    }

    private void button2_Click(object sender, EventArgs e) => refresh();

    private void button1_Click(object sender, EventArgs e)
    {
        if (ready)
        {
            updateapp();
        }
    }

    private void UpdateWindow_FormClosing(object sender, FormClosingEventArgs e) => updatewindowshown = false;
}
