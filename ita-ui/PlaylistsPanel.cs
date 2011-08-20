using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.Services;
using iTunesAgent.Domain;
using iTunesAgent.UI.Components.Wizard;
using iTunesAgent.UI.Controls;
using log4net;
using System.IO;

namespace iTunesAgent.UI
{
    public partial class PlaylistsPanel : UserControl
    {
        private MediaSoftwareService mediaSoftwareService;

        private ModelRepository model;
        
        private MainForm mainForm;
        

        private ILog l = LogManager.GetLogger(typeof(PlaylistsPanel));
        
        public PlaylistsPanel()
        {
            InitializeComponent();
        }

        public MediaSoftwareService MediaSoftwareService
        {
            get { return this.mediaSoftwareService; }
            set { this.mediaSoftwareService = value; }
        }

        public ModelRepository Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public void PlaylistsPanel_Load(object sender, EventArgs e)
        {

            flowPlaylistAssociations.Visible = false;
            
            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

            List<Playlist> playlists = mediaSoftwareService.GetPlaylists();
            foreach (Playlist playlist in playlists)
            {

                PlaylistAssociationControl playlistAssociationControl = new PlaylistAssociationControl();
                playlistAssociationControl.PlaylistName = playlist.Name;
                playlistAssociationControl.PlaylistNameToolTip = playlistAssociationControl.PlaylistName;
                playlistAssociationControl.PlaylistID = playlist.ID;

                UpdateAssociationCountForControl(playlistAssociationControl, deviceCollection);
                
                playlistAssociationControl.AddAssociationButton.Click += new EventHandler(AddAssociationButton_Click);
                playlistAssociationControl.EditAssociationsButton.Click += new EventHandler(EditAssociationsButton_Click);
                playlistAssociationControl.PlaylistNameLabel.Click += new EventHandler(EditAssociationsButton_Click);
                
                flowPlaylistAssociations.Controls.Add(playlistAssociationControl);
            }

            
            flowPlaylistAssociations.Visible = true;
        }
        
        public void EditAssociationsButton_Click(object sender, EventArgs e)
        {
            Control clickedObject = (Control)sender;
            PlaylistAssociationControl playlistAssociationControl = (PlaylistAssociationControl)clickedObject.Parent;
            
            model["editAssociationsPlaylistID"] = playlistAssociationControl.PlaylistID;
            mainForm.SwitchToPanel("associations");
        }
        
        public void AddAssociationButton_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard();
            
            PlaylistAssociationChooseDevicePage devicePage = new PlaylistAssociationChooseDevicePage();
            devicePage.Model = model;
            devicePage.PageTitle = "Choose device";
            
            wizard.Pages.AddLast(devicePage);
            
            PlaylistAssociationBrowseFolder browsePage = new PlaylistAssociationBrowseFolder();
            browsePage.PageTitle = "Choose where music is copied to";
            
            wizard.Pages.AddLast(browsePage);
            
            DialogResult result = wizard.StartWizard(this);
            
            
            if(result == DialogResult.Cancel)
            {
                return;
            }
            
            Device selectedDevice = (Device)wizard.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDDEVICE];
            String selectedPath = (String)wizard.DataStore[WizardDataStoreKeys.PLAYLIST_ASSOCIATION_SELECTEDPATH];
            
            Button senderButton = (Button)sender;
            PlaylistAssociationControl playlistAssociationControl = (PlaylistAssociationControl)senderButton.Parent;
            
            PlaylistAssociation playlistAssociation = new PlaylistAssociation(playlistAssociationControl.PlaylistID, "", selectedPath);
            selectedDevice.Playlists.Add(playlistAssociation);
            
            l.Debug("Attemting to write device configuration to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
            model.Serialize("devices", typeof(DeviceCollection), ApplicationUtils.GetDeviceConfigurationStream(FileMode.Create));
            l.Debug("Device configuration successfully written to: " + ApplicationUtils.DEVICES_CONFIG_PATH);
            
            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");
            UpdateAssociationCountForControl(playlistAssociationControl, deviceCollection);
        }
        
        private void UpdateAssociationCountForControl(PlaylistAssociationControl control, DeviceCollection deviceCollection)
        {
            
            var filtered = from d in deviceCollection.Devices where (from p in d.Playlists where p.PlaylistID == control.PlaylistID select p).Count() > 0 select d;
            int associations = filtered.Count();
            control.AssociationCount = associations;
        }

        public Control FlowPlaylistAssociations
        {
            get
            {
                return this.flowPlaylistAssociations;
            }
        }
        
        public MainForm MainForm 
        {

            get { return mainForm; }
            set { mainForm = value; }
        }


    }
}
