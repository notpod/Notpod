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
            
            NewDeviceWPDConfigurationPage deviceSelectionPage = new NewDeviceWPDConfigurationPage();
            deviceSelectionPage.DevicesService = new WindowsPortableDevicesService();
            deviceSelectionPage.PageTitle = Resources.StrWizardConfigureYourDevice;
            wizard.Pages.AddLast(deviceSelectionPage);
                        
            NewDeviceNamePage namePage = new NewDeviceNamePage();
            namePage.PageTitle = Resources.StrWizardNamePageTitle;
            wizard.Pages.AddLast(namePage);

            NewDevicePlaylistsPage playlistPage = new NewDevicePlaylistsPage();
            playlistPage.PageTitle = Resources.StrWizardPlaylistsPageTitle;
            wizard.Pages.AddLast(playlistPage);

            NewDeviceSummaryPage summaryPage = new NewDeviceSummaryPage();
            summaryPage.PageTitle = Resources.StrWizardSummaryPageTitle;
            wizard.Pages.AddLast(summaryPage);


            wizard.StartWizard(this);
        }
    }
}
