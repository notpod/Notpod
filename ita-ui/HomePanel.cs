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
    public partial class HomePanel : UserControl, ITranslatable
    {
        public HomePanel()
        {
            InitializeComponent();
            TranslationMgr.Attach(this);
        }

        #region ITranslatable Members

        public void OnTranslate()
        {
            labelITunesStatus.Text = Resources.StrNoITunesDetected;
            labelDevicesStatus.Text = Resources.StrNoDevicesManaged;
        }

        #endregion
    }
}
