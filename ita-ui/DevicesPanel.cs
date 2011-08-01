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
using System.IO;
using log4net;

namespace iTunesAgent.UI
{
	public partial class DevicesPanel : UserControl
	{
		private ModelRepository model;
		
		private MainForm mainForm;
		
		private WindowsPortableDevicesService portableDevicesService;
		
		private SupportedDevicesManager supportedDevicesManager;
		
		

		private ILog l = LogManager.GetLogger(typeof(DevicesPanel));

		public DevicesPanel()
		{
			InitializeComponent();
		}

		private void DevicesPanel_Load(object sender, EventArgs e)
		{
			TranslationMgr.Attach(this);
			RefreshDevicesList();
		}

		private void btnNewDevice_Click(object sender, EventArgs e)
		{
			Wizard wizard = new Wizard();

			NewDeviceWelcomePage welcomePage = new NewDeviceWelcomePage();
			welcomePage.PageTitle = Resources.StrWizardWelcomeAddNewPage;
			welcomePage.FinishEnabled = false;
			wizard.Pages.AddLast(welcomePage);

			NewDeviceWPDConfigurationPage deviceSelectionPage = new NewDeviceWPDConfigurationPage();
			deviceSelectionPage.DevicesService = portableDevicesService;
			deviceSelectionPage.PageTitle = Resources.StrWizardConfigureYourDevice;
			deviceSelectionPage.FinishEnabled = false;
			wizard.Pages.AddLast(deviceSelectionPage);

			NewDeviceNamePage namePage = new NewDeviceNamePage();
			namePage.PageTitle = Resources.StrWizardNamePageTitle;
			namePage.FinishEnabled = false;
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
			newDevice.Name = name;

			deviceCollection.Devices.Add(newDevice);
			FlushDeviceConfigurationToFile();
			
			RefreshDevicesList();
			
			if(openDevicePanel) {
				
				mainForm.SwithcToMyDevicesPanel();
			}
		}

		private void FlushDeviceConfigurationToFile()
		{
			l.Debug("Attemting to write device configuration to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
			
			model.Serialize("devices", typeof(DeviceCollection), ApplicationUtils.GetDeviceConfigurationStream(FileMode.Create));

			l.Debug("Device configuration successfully written to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
		}

		public void RefreshDevicesList()
		{

			DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

			lvDevices.Items.Clear();

			foreach (Device device in deviceCollection.Devices)
			{
				ListViewItem item = new ListViewItem();
				item.Text = device.Name;
				item.Name = device.Identifier;
				
				CompatibleDevice connectedDevice = supportedDevicesManager.GetConnectedDevice(device.Identifier);
				if(connectedDevice == null) 
				{
					item.SubItems.Add(Resources.StrDeviceStatusOffline);
				} else {
					
					item.SubItems.Add(Resources.StrDeviceStatusOnline);
				}
				item.SubItems.Add("Unknown");
				item.SubItems.Add("Never");
				lvDevices.Items.Add(item);

			}

			lvDevices.Invalidate();

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
		
		public WindowsPortableDevicesService PortableDevicesService {
			get { return portableDevicesService; }
			set { portableDevicesService = value; }
		}

		public SupportedDevicesManager SupportedDevicesManager {
			get { return supportedDevicesManager; }
			set { supportedDevicesManager = value; }
		}

		
		public MainForm MainForm
		{
			get { return mainForm; }
			set { mainForm = value; }
		}

		private void btnDeleteDevice_Click(object sender, EventArgs e)
		{


			DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

			foreach (ListViewItem listItem in lvDevices.SelectedItems)
			{
				string identifier = listItem.Name;
				deviceCollection.DeleteByIdentifier(identifier);
			}

			FlushDeviceConfigurationToFile();
			
			RefreshDevicesList();
		}

	}
}
