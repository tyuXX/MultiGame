using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string[] masterfile =
                {
                    encode(endecode),
                    encode(username),
                    encode(logupdateinterval.ToString()),
                    encode(autoclickerinterval.ToString()),
                    encode(money.ToString()),
                    encode(generation.ToString()),
                    encode(autogenmult.ToString()),
                    encode(level.ToString()),
                    encode(xp.ToString()),
                    encode(xpn.ToString()),
                    encode(add1.ToString()),
                    encode(add2.ToString()),
                    encode(add3.ToString()),
                    encode(add4.ToString()),
                    encode(add5.ToString()),
                    encode(add6.ToString()),
                    encode(add7.ToString()),
                    encode(add8.ToString()),
                    encode(add9.ToString()),
                    encode(add10.ToString()),
                    encode(mult1.ToString()),
                    encode(mult2.ToString()),
                    encode(mult3.ToString()),
                    encode(mult4.ToString()),
                    encode(mult5.ToString()),
                    encode(mult6.ToString()),
                    encode(mult7.ToString()),
                    encode(mult8.ToString()),
                    encode(mult9.ToString()),
                    encode(mult10.ToString())
                };
                File.WriteAllLines(textBox1.Text,masterfile);
            }
        }
    }
}
