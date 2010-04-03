using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace iTunesAgent.UI
{
    public partial class PreferencesPanel : UserControl
    {

        private ILog l = LogManager.GetLogger(typeof(PreferencesPanel));

        public PreferencesPanel()
        {
            InitializeComponent();
        }

        private void PreferencesPanel_Load(object sender, EventArgs e)
        {            
            l.Debug("Loading PreferencesPanel");
            
        }
    }
}
