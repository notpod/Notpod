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
using iTunesAgent.Domain;

namespace iTunesAgent.UI
{
    public partial class DevicesPanel : UserControl
    {
        private ModelRepository model;

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

            NewDeviceWelcomePage welcomePage = new NewDeviceWelcomePage();
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

            NewDeviceSummaryPage summaryPage = new NewDeviceSummaryPage();
            summaryPage.PageTitle = Resources.StrWizardSummaryPageTitle;
            wizard.Pages.AddLast(summaryPage);


            DialogResult result = wizard.StartWizard(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            AddNewDeviceFromWizardDataStore(wizard);
        }

        private void AddNewDeviceFromWizardDataStore(Wizard wizard)
        {
            CompatibleDevice device = (CompatibleDevice)wizard.DataStore[WizardDataStoreKeys.DEVICE];
            String name = (String)wizard.DataStore[WizardDataStoreKeys.NAME];
            bool openDevicePanel = (bool)wizard.DataStore[WizardDataStoreKeys.OPEN_PLAYLIST_PANEL];

            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

            if (deviceCollection.GetDeviceWithIdentifier(device.Identifier) != null)
            {
                MessageBox.Show(this, "The device you are adding has already been added. You can only "
                    + "add a device once.\n\nIf you want several playlists synchronized to the same "
                    + "device, use the Playlists view to assign more playlists to your device.", 
                    "Device already added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            Device newDevice = new Device();
            newDevice.Identifier = device.Identifier;
            newDevice.Name = device.Name;

            deviceCollection.Devices.Add(newDevice);

            RefreshDevicesList();
        }

        private void RefreshDevicesList()
        {

            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

            lvDevices.Items.Clear();

            foreach (Device device in deviceCollection.Devices)
            {
                ListViewItem item = new ListViewItem();
                item.Text = device.Name;
                item.SubItems.Add(Resources.StrDeviceStatusOffline);
                item.SubItems.Add("Unknown");
                item.SubItems.Add("Never");
                lvDevices.Items.Add(item);

            }

            lvDevices.Refresh();

        }

        public ModelRepository Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }

        }

    }
}
