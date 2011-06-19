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
    public partial class PlaylistAssociationControl : UserControl
    {
        public PlaylistAssociationControl()
        {
            InitializeComponent();
        }

        public String PlaylistName
        {

            get { return this.lblPlaylistName.Text; }
            set { this.lblPlaylistName.Text = value; }
        }

        public string PlaylistNameToolTip
        {
            get { return this.toolTip.GetToolTip(lblPlaylistName); }
            set { this.toolTip.SetToolTip(lblPlaylistName, value); }
        }

        public int AssociationCount
        {
            set
            {
                if (value == 0)
                {
                    this.lblAssociationCount.Text = "Not associations yet.";
                }
                else
                {
                    this.lblAssociationCount.Text = "Will be synchronized to " + value + " device" + (value > 1 ? "s" : "");
                }
            }
        }
    }
}
