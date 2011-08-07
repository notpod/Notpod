/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 07.08.2011
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using iTunesAgent.UI.Properties;
using iTunesAgent.Services;
using iTunesAgent.Domain;


namespace iTunesAgent.UI
{
    /// <summary>
    /// Description of AssociationManagementPanel.
    /// </summary>
    public partial class AssociationManagementPanel : UserControl
    {
        private MainForm mainForm;
        
        private MediaSoftwareService mediaSoftwareService;
        
        private ModelRepository model;
        
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

        
        
        // Using ParentChanged event to update playlist information, as it will always trigger when the panel is added to the container.
        void ParentChangedHandler(object sender, EventArgs e)
        {
            PopulatePlaylistAssociationData();
        }
        
        void PopulatePlaylistAssociationData() 
        {
            int playlistID = model.Get<int>("editAssociationsPlaylistID");
            Playlist playlist = mediaSoftwareService.GetPlaylist(playlistID);
            lblWhereAmI.Text = String.Format("{0} >> {1}", Resources.StrPlaylistAssociationWhereAmIPrefix, playlist.Name);

            DeviceCollection deviceCollection = model.Get<DeviceCollection>("devices");
            var devicesAssociatedWithPlaylist = from d in deviceCollection.Devices where (from p in d.Playlists where p.PlaylistID == playlistID select p).Count() > 0 select d;
            
            listAssociatedDevices.Items.Clear();
            foreach(Device device in devicesAssociatedWithPlaylist) 
            {
                listAssociatedDevices.Items.Add(device);
            }
        }
    }
}
