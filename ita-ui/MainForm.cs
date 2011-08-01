using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using log4net;
using log4net.Config;
using iTunesAgent.Services;
using iTunesAgent.Services.iTunes;
using iTunesAgent.Domain;
using iTunesAgent.UI.Configuration;
using iTunesAgent.Connectors;

namespace iTunesAgent.UI
{
    public partial class MainForm : Form
    {

        
        
        // List holding the different panels (configuration, my devices etc)
        private Dictionary<String, UserControl> panels = new Dictionary<string, UserControl>();

        private ILog l = LogManager.GetLogger(typeof(MainForm));

        private ModelRepository modelRepository = new ModelRepository();
        
        private WindowsPortableDevicesService portableDevicesService;
        
        private SupportedDevicesManager supportedDevicesManager;
        
        private readonly object syncLock = new object();

        private ConfigurationChecker configurationChecker = new ConfigurationCheckerImpl();

        private Dictionary<string, MediaSoftwareService> mediaSoftwareServices = new Dictionary<string, MediaSoftwareService>();

        public MainForm()
        {
            InitializeComponent();
            TranslationMgr.Attach(this);
            configurationChecker.ConfigurationWriter = new DefaultConfigurationToFileWriter(ApplicationUtils.APP_CONFIG_PATH);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BasicConfigurator.Configure();
            
            LoadConfiguration();
            InitializeDevicesManager();
            PopulateMediaSoftwareServices();
            InitializePanels();
            LoadPreviousPanel();
            
        }

        private void InitializeDevicesManager()
        {
            
            portableDevicesService = new WindowsPortableDevicesService();
            supportedDevicesManager = new SupportedDevicesManager();
            supportedDevicesManager.PortableDevicesService = portableDevicesService;
            supportedDevicesManager.ConfiguredDevices = modelRepository.Get<DeviceCollection>("devices");
            supportedDevicesManager.NewDeviceConnected += new NewDeviceConnectedHandler(NewDeviceConnectedEventHandler);
        }
        
        public void NewDeviceConnectedEventHandler(CompatibleDevice connectedDevice)
        {
            DevicesPanel devicesPanel = GetDevicesPanel();
            devicesPanel.RefreshDevicesList();
            
            trayIcon.ShowBalloonTip(2000, "New device connected", connectedDevice.Name 
                                    + " has been connected and is ready to be synchronized.", ToolTipIcon.Info);
        }
        
        private DevicesPanel GetDevicesPanel() {
            
            return (DevicesPanel)panels["devices"];
        }
        
        private void LoadConfiguration()
        {
            modelRepository = ApplicationUtils.LoadModelRepository(configurationChecker);
        }

        private void PopulateMediaSoftwareServices()
        {
            try
            {
                MediaSoftwareService itunesService = new ITunesServiceImpl();
                itunesService.MediaSoftwareConnectionFactory = new ITunesConnectionFactory();
                itunesService.Initialize();
                mediaSoftwareServices.Add(ITunesServiceImpl.SERVICE_NAME, itunesService);
            }
            catch (Exception ex)
            {
                l.Error("Failed to create iTunes API stub.", ex);
                MessageBox.Show(this, "I was unable to communicate with the iTunes interface. You will not be able to synchronize your devices with iTunes.", "Media Software Service initialization failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPreviousPanel()
        {
            Control panel = panels["home"];
            panViewPlaceholder.Controls.Add(panels["home"]);
            panel.Dock = DockStyle.Fill;
            SetSelectedColor(buttonHome);

        }

        private void InitializePanels()
        {
            HomePanel homePanel = new HomePanel();
            homePanel.MediaSoftwareServices = mediaSoftwareServices;
            panels.Add("home", homePanel);

            DevicesPanel devicesPanel = new DevicesPanel();
            devicesPanel.Model = modelRepository;
            devicesPanel.PortableDevicesService = portableDevicesService;
            devicesPanel.SupportedDevicesManager = supportedDevicesManager;
            devicesPanel.MainForm = this;
            panels.Add("devices", devicesPanel);


            DefaultNewPlaylistAssociationFormFactory newPlaylistAssociationFormFactory = new DefaultNewPlaylistAssociationFormFactory();
            newPlaylistAssociationFormFactory.ModelRepository = modelRepository;

            PlaylistsPanel playlistsPanel = new PlaylistsPanel();
            playlistsPanel.MediaSoftwareService = mediaSoftwareServices[ITunesServiceImpl.SERVICE_NAME];
            playlistsPanel.Model = modelRepository;
            panels.Add("playlists", playlistsPanel);

            panels.Add("preferences", new PreferencesPanel());

            setCommonPanelProperties();
        }

        private void setCommonPanelProperties()
        {
            foreach (Control c in panels.Values)
            {
                l.Debug("Setting commons panel properties for " + c.GetType().FullName);
                c.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// WndProc override.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            
            switch(m.Msg) {
                    
                case WMConstants.WM_SYSCOMMAND:
                    
                    if(m.WParam.ToInt32() == WMConstants.SC_MINIMIZE)
                    {
                        Hide();
                        return;
                    }
                    
                    break;
                    
                case WMConstants.WM_DEVICECHANGE:
                    
                    
                    if(m.WParam.ToInt32() == WMConstants.DBT_DEVNODES_CHANGED)
                    {                        
                        supportedDevicesManager.CheckForNewDevices();
                        supportedDevicesManager.CheckForRemovedDevices();
                    }
                    break;
                    
                    
            }
            base.WndProc(ref m);
            
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            ResetButtonState();
            SetSelectedColor(sender);
            switchToPanel("preferences");
        }

        private void btnMyDevices_Click(object sender, EventArgs e)
        {
            ResetButtonState();
            SetSelectedColor(sender);
            switchToPanel("devices");
        }
        
        public void SwithcToMyDevicesPanel()
        {
            btnMyDevices_Click(btnMyDevices, null);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ResetButtonState();
            SetSelectedColor(sender);
            switchToPanel("home");
        }
        
        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            ResetButtonState();
            SetSelectedColor(sender);
            switchToPanel("playlists");
        }

        private void SetSelectedColor(object sender)
        {
            ((Button)sender).BackColor = Color.SkyBlue;
        }

        private void ResetButtonState()
        {
            foreach (Button button in panButtons.Controls.OfType<Button>())
                button.BackColor = Color.White;
        }

        /// <summary>
        /// Switch to the panel named panel_name.
        /// </summary>
        /// <param name="panel_name">Name of panel to switch to. This panel
        /// must be loaded into the panels array.</param>
        private void switchToPanel(string panel_name)
        {
            panViewPlaceholder.Controls.Clear();
            panViewPlaceholder.Controls.Add(panels[panel_name]);
            panViewPlaceholder.Invalidate();
        }

        /*!
         * Accessor for the model repository containing the data model for
         * the application.
         */
        public ModelRepository ModelRepository
        {
            get
            {
                return modelRepository;
            }
            set
            {
                modelRepository = value;
            }

        }

    }
}
