using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.Connectors;
using iTunesAgent.Connectors.Domain;

namespace iTunesAgent.UI.Controls
{
    public partial class NewDeviceNamePage : AbstractWizardPage
    {
        public NewDeviceNamePage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            String deviceName = (String)DataStore[WizardDataStoreKeys.NAME];
            if (deviceName != null)
            {
                textDeviceName.Text = deviceName;

            }
            else
            {
                CompatibleDevice selecteDevice = (CompatibleDevice)DataStore[WizardDataStoreKeys.DEVICE];
                    textDeviceName.Text = "My " + selecteDevice.Name;                
            }
        }

        public override bool ValidateBeforeNext()
        {
            if (String.IsNullOrEmpty(textDeviceName.Text))
            {
                MessageBox.Show(this, "You must enter a name for your device before continuing.",
                    "Seems you forgot something!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DataStore[WizardDataStoreKeys.NAME] = textDeviceName.Text;
            return true;
        }
    }
}
