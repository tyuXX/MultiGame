using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Tools
{
    public partial class AddLog : Form
    {
        public AddLog()
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
            if(!(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked))
            {
                merge += "(Log)";
            }
            merge += "}";
            merge2 = merge2.Replace("$datenow",DateTime.Now.ToString());
            merge2 = merge2.Replace("$clshown",clshown.ToString());
            merge2 = merge2.Replace("$fnfshown",fnfshown.ToString());
            merge2 = merge2.Replace("$logshown",logshown.ToString());
            merge2 = merge2.Replace("$addlogshown",addlogshown.ToString());
            merge2 = merge2.Replace("$toggledevmodeshown", toggledevmodeshown.ToString());
            merge2 = merge2.Replace("$devmode",devmode.ToString());
            merge2 = merge2.Replace("$logupdateinterval", logupdateinterval.ToString());
            merge2 = merge2.Replace("$money", money.ToString());
            merge2 = merge2.Replace("$generation", generation.ToString());
            merge2 = merge2.Replace("$level", level.ToString());
            merge2 = merge2.Replace("$xp", xp.ToString());
            merge2 = merge2.Replace("$xpn", xpn.ToString());
            merge2 = merge2.Replace("$add1", add1.ToString());
            merge2 = merge2.Replace("$add2", add2.ToString());
            merge2 = merge2.Replace("$add3", add3.ToString());
            merge2 = merge2.Replace("$add4", add4.ToString());
            merge2 = merge2.Replace("$add5", add5.ToString());
            merge2 = merge2.Replace("$add6", add6.ToString());
            merge2 = merge2.Replace("$add7", add7.ToString());
            merge2 = merge2.Replace("$add8", add8.ToString());
            merge2 = merge2.Replace("$add9", add9.ToString());
            merge2 = merge2.Replace("$add10", add10.ToString());
            merge2 = merge2.Replace("$mult1", mult1.ToString());
            merge2 = merge2.Replace("$mult2", mult2.ToString());
            merge2 = merge2.Replace("$mult3", mult3.ToString());
            merge2 = merge2.Replace("$mult4", mult4.ToString());
            merge2 = merge2.Replace("$mult5", mult5.ToString());
            merge2 = merge2.Replace("$mult6", mult6.ToString());
            merge2 = merge2.Replace("$mult7", mult7.ToString());
            merge2 = merge2.Replace("$mult8", mult8.ToString());
            merge2 = merge2.Replace("$mult9", mult9.ToString());
            merge2 = merge2.Replace("$mult10", mult10.ToString());
            log.Add(merge + merge2);
            textBox1.Clear();
        }

        private void AddLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/AddLog/Form]{(Log)}Closing Form");
            addlogshown = false;
        }

        private void AddLog_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/AddLog/Form]{(Log)}Opening Form");
        }
    }
}
