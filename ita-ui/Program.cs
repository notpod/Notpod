using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using log4net.Config;

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
            
            XmlConfigurator.Configure(new FileInfo("logging.xml"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            ModelRepository repo = new ModelRepository();
            
            Application.Run(form);
                                  
        }
    }
}
