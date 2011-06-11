using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using iTunesAgent.Services;
using iTunesAgent.Services.iTunes;
using iTunesAgent.Domain;

namespace iTunesAgent.UI
{
    public partial class MainForm : Form
    {

        //Constants used when intercepting system messages
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;

        // List holding the different panels (configuration, my devices etc)
        private Dictionary<String, UserControl> panels = new Dictionary<string, UserControl>();

        private ILog l = LogManager.GetLogger(typeof(MainForm));

        private ModelRepository modelRepository = new ModelRepository();

        private Dictionary<string, MediaSoftwareService> mediaSoftwareServices = new Dictionary<string, MediaSoftwareService>();

        public MainForm()
        {
            InitializeComponent();
            TranslationMgr.Attach(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
            PopulateMediaSoftwareServices();
            InitializePanels();            
            LoadPreviousPanel();
        }

        private void LoadConfiguration()
        {
            modelRepository["devices"] = new DeviceCollection();
        }

        private void PopulateMediaSoftwareServices()
        {
            try
            {
                MediaSoftwareService itunesService = new ITunesServiceImpl();
                itunesService.MediaSoftwareConnectionFactory = new ITunesConnectionFactory();
                itunesService.Initialize();
                mediaSoftwareServices.Add("itunes", itunesService);
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
            panels.Add("devices", devicesPanel);
            
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
        /// WndProc override to enable minimize to tray.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                switch (m.WParam.ToInt32())
                {
                    case SC_MINIMIZE:
                        {
                            Hide();
                            return;
                        }
                    default:
                        {
                            break;
                        }
                }
            }

            //Let the base class handle the rest.
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ResetButtonState();
            SetSelectedColor(sender);
            switchToPanel("home");
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
