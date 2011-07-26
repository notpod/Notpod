/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 20.07.2011
 * Time: 15:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.Domain;

namespace iTunesAgent.UI.Controls
{
    /// <summary>
    /// Description of PlaylistAssociationChooseDevicePage.
    /// </summary>
    public partial class PlaylistAssociationChooseDevicePage : AbstractWizardPage
    {
        
        private ModelRepository model;
        
        
        public PlaylistAssociationChooseDevicePage()
        {
            
            InitializeComponent();
        }
        
        public ModelRepository Model {

            get { return model; }
            set { model = value; }
        }
        
        public override void Populate()
        {
            DeviceCollection devices = model.Get<DeviceCollection>("devices");
            foreach(Device device in devices.Devices)
            {
                cbDevices.Items.Add(device);
            }
            
            
            Device previouslySelectedDevice = (Device)this.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDDEVICE];
            if(previouslySelectedDevice != null)
            {
                cbDevices.SelectedItem = previouslySelectedDevice;
            }
        }
        
        public override bool ValidateBeforeNext()
        {
            Device selectedDevice = (Device)cbDevices.SelectedItem;
            if(selectedDevice == null) {
                
                MessageBox.Show(this, "Please select the device you want to associate with the playlist.", "Select device", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            this.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDDEVICE] = selectedDevice;
            return true;
        }
        
        #if DEBUG
        public ComboBox SelectedDeviceComboBox {
            
            get { return cbDevices; }
        }
        #endif
    }
}
