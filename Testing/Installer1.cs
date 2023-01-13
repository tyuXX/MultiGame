using System.ComponentModel;

namespace Testing
{
    [RunInstaller( true )]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
    }
}
