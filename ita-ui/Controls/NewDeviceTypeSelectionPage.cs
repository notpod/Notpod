using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;

namespace iTunesAgent.UI.Controls
{
    public partial class NewDeviceTypeSelectionPage : AbstractWizardPage
    {
        public NewDeviceTypeSelectionPage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            String deviceType = (String)DataStore["deviceType"];
            if (deviceType != null && deviceType == "windowsPortableDevice")
            {
                radioWindowsPortableDevice.Checked = true;
            }
            else
            {
                radioMassStorage.Checked = true;
            }
        }

        public override bool ValidateBeforeNext()
        {
            if (!radioMassStorage.Checked && !radioWindowsPortableDevice.Checked)
            {
                MessageBox.Show(this, "You have to select a device type",
                    "You need to select what type of device you are configuring. If you are uncertain, "
                    + "click the link at the bottom of the dialog to go online for more help.", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return false;
            }


            if (radioMassStorage.Checked)
            {
                DataStore["deviceType"] = "massStorageDevice";
            }
            else
            {
                DataStore["deviceType"] = "windowsPortableDevice";
            }

            return true;
        }
    }
}
