/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 07.08.2011
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using iTunesAgent.UI.Properties;
using iTunesAgent.Services;
using iTunesAgent.Domain;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.UI.Controls;
using iTunesAgent.Connectors;
using log4net;

namespace iTunesAgent.UI
{
    /// <summary>
    /// Description of AssociationManagementPanel.
    /// </summary>
    public partial class AssociationManagementPanel : UserControl
    {
        private MainForm mainForm;
        
        private MediaSoftwareService mediaSoftwareService;
        
        private IDevicesManager devicesManager;
        
        private ModelRepository model;
        
        private ILog l = LogManager.GetLogger(typeof(AssociationManagementPanel));
        
        public AssociationManagementPanel()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
        void BtnBackClick(object sender, EventArgs e)
        {
            
            mainForm.SwitchToPanel("playlists");
        }
        
        public ModelRepository Model
        {
            
            get { return model; }
            set { model = value; }
        }

        
        public MainForm MainForm {
            
            get { return mainForm; }
            set { mainForm = value; }
        }
        
        public MediaSoftwareService MediaSoftwareService {
            get { return mediaSoftwareService; }
            set { mediaSoftwareService = value; }
        }
        
        public IDevicesManager DevicesManager {
            get { return devicesManager; }
            set { devicesManager = value; }
        }
        
        // Using ParentChanged event to update playlist information, as it will always trigger when the panel is added to the container.
        void ParentChangedHandler(object sender, EventArgs e)
        {
            PopulatePlaylistAssociationData();
        }
        
        void PopulatePlaylistAssociationData()
        {
            int playlistID = model.Get<int>("editAssociationsPlaylistID");
            
            UpdatePlaylistName(playlistID);
            UpdateAssociatedPlaylists(playlistID);
        }
        
        void UpdatePlaylistName(int playlistID)
        {
            Playlist playlist = mediaSoftwareService.GetPlaylist(playlistID);
            lblWhereAmI.Text = String.Format("{0} >> {1}", Resources.StrPlaylistAssociationWhereAmIPrefix, playlist.Name);
        }
        
        void UpdateAssociatedPlaylists(int playlistID)
        {
            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");
            var devicesAssociatedWithPlaylist = from d in deviceCollection.Devices where (from p in d.Playlists where p.PlaylistID == playlistID select p).Count() > 0 select d;
            
            listAssociatedDevices.Items.Clear();
            foreach(Device device in devicesAssociatedWithPlaylist)
            {
                listAssociatedDevices.Items.Add(device);
            }
        }
        
        void BtnNewClick(object sender, EventArgs e)
        {
            int playlistID = model.Get<int>("editAssociationsPlaylistID");
            
            Wizard wizard = new Wizard();
            
            PlaylistAssociationChooseDevicePage devicePage = new PlaylistAssociationChooseDevicePage();
            devicePage.Model = model;
            devicePage.PageTitle = "Choose device";
            
            wizard.Pages.AddLast(devicePage);
            
            PlaylistAssociationBrowseFolder browsePage = new PlaylistAssociationBrowseFolder();
            browsePage.PageTitle = "Choose where music is copied to";
            browsePage.DevicesManager = devicesManager;
            
            wizard.Pages.AddLast(browsePage);
            
            DialogResult result = wizard.StartWizard(this);
            
            
            if(result == DialogResult.Cancel)
            {
                return;
            }
            
            Device selectedDevice = (Device)wizard.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDDEVICE];
            String selectedPath = (String)wizard.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDPATH];
            
            PlaylistAssociation playlistAssociation = new PlaylistAssociation(playlistID, "", selectedPath);
            selectedDevice.Playlists.Add(playlistAssociation);
            
            
            SerializeDeviceConfiguration();
            
            UpdateAssociatedPlaylists(playlistID);
        }

        void SerializeDeviceConfiguration()
        {
            l.Debug("Attemting to write device configuration to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
            model.Serialize("devices", typeof(DeviceCollection), ApplicationUtils.GetDeviceConfigurationStream(FileMode.Create));
            l.Debug("Device configuration successfully written to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
        }
        
        void BtnDeleteClick(object sender, EventArgs e)
        {
            Device selectedDevice = (Device)listAssociatedDevices.SelectedItem;
            if(selectedDevice == null)
            {
                MessageBox.Show(this, Resources.StrAssocationManagmentSelectDevice, Resources.StrGeneralInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            int playlistID = model.Get<int>("editAssociationsPlaylistID");
            IEnumerable<PlaylistAssociation> association = from p in selectedDevice.Playlists where p.PlaylistID == playlistID select p;
            
            selectedDevice.Playlists.Remove(association.FirstOrDefault());
            
            SerializeDeviceConfiguration();
            UpdateAssociatedPlaylists(playlistID);
        }
    }
}
