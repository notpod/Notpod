using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using iTunesAgent.UI.Properties;
using iTunesAgent.Domain;

namespace iTunesAgent.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            if (String.IsNullOrEmpty(Configuration.Instance().Language ))
                Configuration.Instance().Language = "en-GB";
            Application.CurrentCulture = new CultureInfo(Configuration.Instance().Language);
            Thread.CurrentThread.CurrentUICulture = Application.CurrentCulture;
            
            Application.Run(new MainForm());
        }
    }
}
