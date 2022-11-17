using MultiGame.Tools;
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
    public partial class GamesInc : Form
    {
        public GamesInc()
        {
            InitializeComponent();
        }

        private void GamesInc_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Form]{(Log)}Closing Form");
        }

        private void GamesInc_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Form]{(Log)}Opening Form");
        }
    }
}
