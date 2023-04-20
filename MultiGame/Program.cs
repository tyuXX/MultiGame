namespace MultiGame;

static class Program
{
    [STAThread]
    internal static void Main(string[ ] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        mainform = new Main();
        argscontrol(args);
        Application.Run(mainform);
    }
    private static void argscontrol(string[ ] args)
    {
        foreach (string str in args)
        {
            if (str.Substring(0, 2) == "--")
            {
                switch (str)
                {
                    case "--nosplash":
                        {
                            mainform.splash = false;
                            break;
                        }
                    case "--$sct":
                        {
                            devmode = true;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
