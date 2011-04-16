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
    public partial class NewDeviceTypeBasedConditionalPage : AbstractConditionalWizardPage
    {
        private AbstractWizardPage massStorageDeviceConfigurationPage;

        private AbstractWizardPage windowsPortableDeviceConfigurationPage;
        
        public NewDeviceTypeBasedConditionalPage()
        {

        }

        public AbstractWizardPage MassStorageDevicePage
        {
            set { this.massStorageDeviceConfigurationPage = value; }
        }

        public AbstractWizardPage WindowsPortableDevicePage
        {
            set { this.windowsPortableDeviceConfigurationPage = value; }
        }


        public override AbstractWizardPage GetWizardPage()
        {
            String deviceType = (String)DataStore["deviceType"];
            if (deviceType == "massStorageDevice")
            {
                return massStorageDeviceConfigurationPage;
            }

            return windowsPortableDeviceConfigurationPage;
        }
    }
}
