﻿using System;
using System.Reflection;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Tools
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        public string AssemblyTitle
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
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
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

        public string AssemblyProduct
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

        public string AssemblyCopyright
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

        public string AssemblyCompany
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            aboutshown = false;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}