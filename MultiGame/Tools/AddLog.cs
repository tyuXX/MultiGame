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
            merge2 = merge2.Replace("$devmode",devmode.ToString());
            merge2 = merge2.Replace("$logupdateinterval", logupdateinterval.ToString());
            merge2 = merge2.Replace("$money", money.ToString());
            merge2 = merge2.Replace("$money", money.ToString());
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
