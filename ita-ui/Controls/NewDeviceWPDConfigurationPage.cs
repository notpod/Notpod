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
    public partial class NewDeviceWPDConfigurationPage : AbstractWizardPage
    {
        private WindowsPortableDevicesService devicesService;

        private Dictionary<string, string> deviceMap = new Dictionary<string, string>();

        public NewDeviceWPDConfigurationPage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            CompatibleDevice selectedDevice = (CompatibleDevice)DataStore[WizardDataStoreKeys.DEVICE];
                        
            listWPDDevices.Items.Clear();

            string[] deviceIds = devicesService.GetDeviceIds();
            foreach (string deviceId in deviceIds)
            {
                CompatibleDevice device = devicesService.GetDeviceById(deviceId);
                device.Connect();
                device.Disconnect();
                listWPDDevices.Items.Add(device);

                if (selectedDevice != null && selectedDevice.Identifier == device.Identifier)
                {
                    listWPDDevices.SelectedItem = device;
                }
            }
                        
        }

        public override bool ValidateBeforeNext()
        {
            WindowsPortableDevice device = (WindowsPortableDevice)listWPDDevices.SelectedItem;
            if (device == null)
            {
                MessageBox.Show(this, "You must your Portable Media Device before continuing.", "Choose a device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DataStore[WizardDataStoreKeys.DEVICE] = device;
            return true;
        }

        public WindowsPortableDevicesService DevicesService
        {
            get { return devicesService; }
            set { this.devicesService = value; }
        }
    }
}
