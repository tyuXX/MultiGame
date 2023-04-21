using System.Reflection;

namespace MultiGame.Tools;

partial class About : Form
{
    internal About()
    {
        InitializeComponent();
        Text = String.Format("About {0}", AssemblyTitle);
        labelProductName.Text = AssemblyProduct;
        labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
        labelCopyright.Text = AssemblyCopyright;
        labelCompanyName.Text = AssemblyCompany;
        textBoxDescription.Text = AssemblyDescription;
    }

    internal string AssemblyTitle
    {
        get
        {
            object[ ] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0)
            {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[ 0 ];
                if (titleAttribute.Title != "")
                {
                    return titleAttribute.Title;
                }
            }
            return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
        }
    }

    internal string AssemblyVersion
    {
        get
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }

    internal string AssemblyDescription
    {
        get
        {
            object[ ] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyDescriptionAttribute)attributes[ 0 ]).Description;
        }
    }

    internal string AssemblyProduct
    {
        get
        {
            object[ ] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[ 0 ]).Product;
        }
    }

    internal string AssemblyCopyright
    {
        get
        {
            object[ ] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[ 0 ]).Copyright;
        }
    }

    internal string AssemblyCompany
    {
        get
        {
            object[ ] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCompanyAttribute)attributes[ 0 ]).Company;
        }
    }

    private void okButton_Click(object sender, EventArgs e) => Close();

    private void About_FormClosing(object sender, FormClosingEventArgs e) => aboutshown = false;

    private void About_Load(object sender, EventArgs e)
    {

    }
}
