﻿namespace MultiGame.Tools
{
    public partial class OpenGame : Form
    {
        public OpenGame()
        {
            InitializeComponent();
        }

        private void OpenGame_Load(object sender, EventArgs e)
        {

        }

        private void OpenGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            opengameshown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opengame(textBox1.Text, textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Save File For MultiGame";
            openFileDialog1.DefaultExt = ".mgs";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
