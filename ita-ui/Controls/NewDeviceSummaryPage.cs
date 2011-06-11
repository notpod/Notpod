using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.Connectors.Domain;

namespace iTunesAgent.UI.Controls
{
    public partial class NewDeviceSummaryPage : AbstractWizardPage
    {
        public NewDeviceSummaryPage()
        {
            InitializeComponent();
        }

        public override void  Populate()
        {
            labelDeviceName.Text = (string)DataStore[WizardDataStoreKeys.NAME];
        }

        public override bool ValidateBeforeNext()
        {
            DataStore[WizardDataStoreKeys.OPEN_PLAYLIST_PANEL] = cbOpenPlaylistsPanelOnFinish.Checked;
            return true;
        }
    }
}
