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

namespace iTunesAgent.UI
{
    public partial class PlaylistsPanel : UserControl
    {
        private MediaSoftwareService mediaSoftwareService;

        private ModelRepository model;

        private INewPlaylistAssociationFormFactory newPlaylistAssociationFormFactory;

        public PlaylistsPanel()
        {
            InitializeComponent();
        }

        public INewPlaylistAssociationFormFactory NewPlaylistAssociationFormFactory
        {
            get { return this.newPlaylistAssociationFormFactory; }
            set { this.newPlaylistAssociationFormFactory = value; }
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

            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");

            List<Playlist> playlists = mediaSoftwareService.GetPlaylists();
            foreach (Playlist playlist in playlists)
            {

                PlaylistAssociationControl playlistAssociationControl = new PlaylistAssociationControl();
                playlistAssociationControl.PlaylistName = playlist.Name;
                playlistAssociationControl.PlaylistNameToolTip = playlistAssociationControl.PlaylistName;
                playlistAssociationControl.PlaylistID = playlist.ID;

                int associations = deviceCollection.Devices.Count(d => d.Playlists.Select(p => p.PlaylistID == playlist.ID).Count() > 0);
                playlistAssociationControl.AssociationCount = associations;

                playlistAssociationControl.AddAssociationButton.Click += new EventHandler(AddAssociationButton_Click);
                                
                flowPlaylistAssociations.Controls.Add(playlistAssociationControl);
            }

        }
        
        public void AddAssociationButton_Click(object sender, EventArgs e)
        {                        
            NewPlaylistAssociationForm newAssociationForm = newPlaylistAssociationFormFactory.NewInstance();
            newAssociationForm.ShowDialog(this);
            
        }

        public Control FlowPlaylistAssociations
        {
            get
            {
                return this.flowPlaylistAssociations;
            }
        }



    }
}
