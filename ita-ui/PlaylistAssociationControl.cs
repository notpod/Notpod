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

        private int playlistID;

        public PlaylistAssociationControl()
        {
            InitializeComponent();
        }

        public int PlaylistID
        {
            get
            {
                return this.playlistID;
            }
            set
            {
                this.playlistID = value;
            }
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

        public Button AddAssociationButton
        {
            get
            {
                return this.btnAddAssociation;
            }
        }

        public Button EditAssociationsButton
        {
            get
            {
                return this.btnEditAssociations;
            }
        }
        
        public Button ClearAllAssociationsButton
        {
            
            get { return this.btnClearAll; }
        }

        public Button SynchronizePlaylistButton
        {
            get
            {
                return this.btnSynchronizeNow;
            }
        }
        
        public Label PlaylistNameLabel 
        {
            get { return this.lblPlaylistName; }
        }
        
        void LblPlaylistNameMouseEnter(object sender, EventArgs e)
        {
        	lblPlaylistName.ForeColor = Color.Blue;        	
        }
        
        void LblPlaylistNameMouseLeave(object sender, EventArgs e)
        {
        	lblPlaylistName.ForeColor = Color.Black;
        }
    }
}
