using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Properties;

namespace iTunesAgent.UI
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
            labelITunesStatus.Text = Resources.StrNoITunesDetected;
            labelDevicesStatus.Text = Resources.StrNoDevicesManaged;
        }
    }
}
