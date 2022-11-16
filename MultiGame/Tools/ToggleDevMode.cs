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
    public partial class ToggleDevMode : Form
    {
        public ToggleDevMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string str in passcodes)
            {
                if(str == textBox1.Text)
                {
                    devmode = true;
                    log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/PassCode]{(Log)}Logged In with PassCode" + str);
                    this.Close();
                }
                else
                {
                    textBox1.Text = "Unknown PassCode";
                }
            }
        }

        private void ToggleDevMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/Form]{(Log)}Closing Form");
        }

        private void ToggleDevMode_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Devoloper/ToggleDevMode/Form]{(Log)}Opening Form");
        }
    }
}
