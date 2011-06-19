using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.Services;

namespace iTunesAgent.UI
{
    public partial class PlaylistsPanel : UserControl
    {
        private MediaSoftwareService mediaSoftwareService;

        public PlaylistsPanel()
        {
            InitializeComponent();
        }


        public MediaSoftwareService MediaSoftwareService
        {
            get { return this.mediaSoftwareService; }
            set { this.mediaSoftwareService = value; }
        }

        private void PlaylistsPanel_Load(object sender, EventArgs e)
        {
            List<Playlist> playlists = mediaSoftwareService.GetPlaylists();
            foreach(Playlist playlist in playlists) {

                PlaylistAssociationControl playlistAssociationControl = new PlaylistAssociationControl();
                playlistAssociationControl.PlaylistName = playlist.Name;
                playlistAssociationControl.PlaylistNameToolTip = playlistAssociationControl.PlaylistName;

                flowPlaylistAssociations.Controls.Add(playlistAssociationControl);
            }

        }



    }
}
