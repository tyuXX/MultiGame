﻿namespace MultiGame.Tools;

internal partial class AddLog : Form
{
    internal AddLog()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string merge = "[" + DateTime.Now + "][From:Internal/Devoloper/Console]{";
        string merge2 = textBox1.Text;
        if (checkBox1.Checked)
        {
            merge += "(Important)";
        }
        if (checkBox2.Checked)
        {
            merge += "(Error)";
        }
        if (checkBox3.Checked)
        {
            merge += "(Fatal Error)";
        }
        if (!(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked))
        {
            merge += "(Log)";
        }
        merge += "}";
        merge2 = merge2.Replace("$datenow", DateTime.Now.ToString());
        merge2 = merge2.Replace("$clshown", clshown.ToString());
        merge2 = merge2.Replace("$fnfshown", fnfshown.ToString());
        merge2 = merge2.Replace("$logshown", logshown.ToString());
        merge2 = merge2.Replace("$addlogshown", addlogshown.ToString());
        merge2 = merge2.Replace("$toggledevmodeshown", toggledevmodeshown.ToString());
        merge2 = merge2.Replace("$shopshown", shopshown.ToString());
        merge2 = merge2.Replace("$devmode", devmode.ToString());
        merge2 = merge2.Replace("$logupdateinterval", logupdateinterval.ToString());
        merge2 = merge2.Replace("$autoclickerinterval", autoclickerinterval.ToString());
        merge2 = merge2.Replace("$money", money.ToString());
        merge2 = merge2.Replace("$generation", generation.ToString());
        merge2 = merge2.Replace("$autogenmult", autogenmultu.ToString());
        merge2 = merge2.Replace("$level", level.ToString());
        merge2 = merge2.Replace("$xp", xp.ToString());
        merge2 = merge2.Replace("$xpn", xpn.ToString());
        merge2 = merge2.Replace("$add1", add1u.ToString());
        merge2 = merge2.Replace("$add2", add2u.ToString());
        merge2 = merge2.Replace("$add3", add3u.ToString());
        merge2 = merge2.Replace("$add4", add4u.ToString());
        merge2 = merge2.Replace("$add5", add5u.ToString());
        merge2 = merge2.Replace("$add6", add6u.ToString());
        merge2 = merge2.Replace("$add7", add7u.ToString());
        merge2 = merge2.Replace("$add8", add8u.ToString());
        merge2 = merge2.Replace("$add9", add9u.ToString());
        merge2 = merge2.Replace("$add10", add10u.ToString());
        merge2 = merge2.Replace("$mult1", mult1u.ToString());
        merge2 = merge2.Replace("$mult2", mult2u.ToString());
        merge2 = merge2.Replace("$mult3", mult3u.ToString());
        merge2 = merge2.Replace("$mult4", mult4u.ToString());
        merge2 = merge2.Replace("$mult5", mult5u.ToString());
        merge2 = merge2.Replace("$mult6", mult6u.ToString());
        merge2 = merge2.Replace("$mult7", mult7u.ToString());
        merge2 = merge2.Replace("$mult8", mult8u.ToString());
        merge2 = merge2.Replace("$mult9", mult9u.ToString());
        merge2 = merge2.Replace("$mult10", mult10u.ToString());
        textBox1.Clear();
    }

    private void AddLog_FormClosing(object sender, FormClosingEventArgs e) => addlogshown = false;

    private void AddLog_Load(object sender, EventArgs e)
    {

    }
}
