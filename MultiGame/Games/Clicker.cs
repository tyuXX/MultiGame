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

namespace MultiGame.Games
{
    public partial class Clicker : Form
    {
        public Clicker()
        {
            InitializeComponent();
        }

        private void Clicker_Load(object sender, EventArgs e)
        {

        }

        private void Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            clshown = false;
        }
    }
}
