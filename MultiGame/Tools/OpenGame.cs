﻿namespace MultiGame.Tools;

internal partial class OpenGame : Form
{
    internal OpenGame()
    {
        InitializeComponent();
    }

    private void OpenGame_Load(object sender, EventArgs e)
    {

    }

    private void OpenGame_FormClosing(object sender, FormClosingEventArgs e) => opengameshown = false;

    private void button2_Click(object sender, EventArgs e) => opengame(textBox1.Text, textBox2.Text, this);

    private void button1_Click(object sender, EventArgs e)
    {
        ToggleTickers();
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox1.Text = openFileDialog1.FileName;
        }
        ToggleTickers();
    }
}
