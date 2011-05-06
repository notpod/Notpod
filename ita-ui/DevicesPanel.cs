using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.UI.Properties;
using iTunesAgent.UI.Controls;
using iTunesAgent.Connectors;

namespace iTunesAgent.UI
{
    public partial class DevicesPanel : UserControl
    {
        
        public DevicesPanel()
        {            
            InitializeComponent();            
        }

        private void DevicesPanel_Load(object sender, EventArgs e)
        {
            TranslationMgr.Attach(this);
        }

        private void btnNewDevice_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard();
            
            NewDeviceWelcomePage welcomePage  = new NewDeviceWelcomePage();
            welcomePage.PageTitle = Resources.StrWizardWelcomeAddNewPage;
            welcomePage.FinishEnabled = false;
            wizard.Pages.AddLast(welcomePage);

            NewDeviceNamePage namePage = new NewDeviceNamePage();
            namePage.PageTitle = "Name your device";            
            wizard.Pages.AddLast(namePage);

            NewDeviceTypeSelectionPage typePage = new NewDeviceTypeSelectionPage();
            typePage.PageTitle = "Choose your device type";
            wizard.Pages.AddLast(typePage);

            NewDeviceMSDConfigurationPage msdPage = new NewDeviceMSDConfigurationPage();
            msdPage.PageTitle = "Configure your device";

            NewDeviceWPDConfigurationPage wpdPage = new NewDeviceWPDConfigurationPage();
            wpdPage.DevicesService = new WindowsPortableDevicesService();
            wpdPage.PageTitle = "Configure your device";

            NewDeviceTypeBasedConditionalPage deviceConfigurationPage = new NewDeviceTypeBasedConditionalPage();
            deviceConfigurationPage.MassStorageDevicePage = msdPage;
            deviceConfigurationPage.WindowsPortableDevicePage = wpdPage;
            wizard.Pages.AddLast(deviceConfigurationPage);

            NewDeviceSummaryPage summaryPage = new NewDeviceSummaryPage();
            summaryPage.PageTitle = "Summary";

            wizard.Pages.AddLast(summaryPage);


            wizard.StartWizard(this);
        }
    }
}
