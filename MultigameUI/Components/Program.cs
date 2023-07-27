using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultigameUI.Components
{
    public partial class Program : UserControl
    {
        Form onopen = new Form();
        public Program()
        {
            InitializeComponent();
        }

        private void Program_DoubleClick( object sender, EventArgs e )
        {
            onopen.MdiParent = ParentForm;
            onopen.Show();
        }
    }
}
