﻿namespace MultiGame.Games;

internal partial class Clicker : Form
{
    internal Clicker()
    {
        InitializeComponent();
    }

    private void Clicker_Load(object sender, EventArgs e)
    {

    }

    private void Clicker_FormClosing(object sender, FormClosingEventArgs e) => clshown = false;

    private void button1_Click(object sender, EventArgs e)
    {
        money += getmoney;
        xp += getmoney;
        totalclicks++;
        totalclicksdirect++;
    }

    private void tick_Tick(object sender, EventArgs e)
    {
        if (formatnums)
        {
            label1.Text = "Money:" + FormatBigNum(money);
        }
        else
        {
            label1.Text = "Money:" + money;
        }
    }
}
