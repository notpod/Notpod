using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI
{
    public partial class PlaylistsPanel : UserControl
    {
        public PlaylistsPanel()
        {
            InitializeComponent();
        }

        private void PlaylistsPanel_Load(object sender, EventArgs e)
        {
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
            flowPlaylistAssociations.Controls.Add(new PlaylistAssociationControl());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
