using System;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Tools
{
    public partial class SaveGame : Form
    {
        public SaveGame()
        {
            InitializeComponent();
        }

        private void SaveGame_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/SaveGame/Form]{(Log)}Opening Form");
        }

        private void SaveGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Tool/SaveGame/Form]{(Log)}Closing Form");
            savegameshown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savefiledia.Title = "Save Game File Of MultiGame";
            if (savefiledia.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = savefiledia.FileName;
                log.Add("[" + DateTime.Now + "][From:Internal/Tool/SaveGame/FileSelector]{(Log)}Selected File Name:" + '"' + savefiledia.FileName + '"'); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savegame(textBox1.Text);
        }
    }
}
