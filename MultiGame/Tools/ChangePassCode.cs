﻿namespace MultiGame.Tools;

internal partial class ChangePassCode : Form
{
    internal ChangePassCode()
    {
        InitializeComponent();
    }

    private void ChangePassCode_FormClosing(object sender, FormClosingEventArgs e) => changepasscodeshown = false;

    private void ChangePassCode_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == endecode)
        {
            endecode = textBox2.Text;
            Close();
        }
    }
}
