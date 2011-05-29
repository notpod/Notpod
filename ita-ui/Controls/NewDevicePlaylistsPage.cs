using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;

namespace iTunesAgent.UI.Controls
{
    public partial class NewDevicePlaylistsPage : AbstractWizardPage
    {
        public NewDevicePlaylistsPage()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newListitem = new ListViewItem("Playlist name...");            
            lvPlaylists.Items.Add(newListitem);
            newListitem.BeginEdit();
        }
    }
}
