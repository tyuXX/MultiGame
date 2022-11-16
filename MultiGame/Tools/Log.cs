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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = logupdateinterval;
            richTextBox1.Clear();
            foreach(string str in log)
            {
                richTextBox1.Text += str + "\n";
            }
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/Log/Form]{(Log)}Closing Form");
            logshown = false;
        }

        private void Log_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/Log/Form]{(Log)}Opening Form");
        }
    }
}
