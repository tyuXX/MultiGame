using System;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainform = new Main();
            Application.Run(mainform);
        }
    }
}
