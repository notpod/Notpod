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
    public partial class NewDeviceNamePage : AbstractWizardPage
    {
        public NewDeviceNamePage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            
        }

        public override bool ValidateBeforeNext()
        {
            if (String.IsNullOrEmpty(textDeviceName.Text))
            {
                MessageBox.Show(this, "You must enter a name for your device before continuing.", 
                    "Seems you forgot something!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DataStore["deviceName"] = textDeviceName.Text;
            return true;
        }
    }
}
