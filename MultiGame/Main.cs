using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiGame
{
    public partial class Main : Form
    {
        bool clshown = false;
        public Main()
        {
            InitializeComponent();
        }

        private void clickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clshown)
            {
                clshown = true;
                Form fm = new Games.Clicker();
                fm.MdiParent = this;
                fm.Show();
            }
        }
    }
}
