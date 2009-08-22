using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI
{
    public partial class MainForm : Form
    {
        //Constants used when intercepting system messages
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;

        // List holding the different panels (configuration, my devices etc)
        private Dictionary<String, UserControl> panels = new Dictionary<string, UserControl>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializePanels();
            LoadPreviousPanel();
        }


        private void LoadPreviousPanel()
        {
            Control panel = panels["devices"];
            panViewPlaceholder.Controls.Add(panels["devices"]);
            panel.Dock = DockStyle.Fill;
            
        }

        private void InitializePanels()
        {
            panels.Add("devices", new DevicesPanel());
            panels.Add("preferences", new PreferencesPanel());
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
            panViewPlaceholder.Controls.Clear();
            panViewPlaceholder.Controls.Add(panels["preferences"]);
            panViewPlaceholder.Invalidate();
        }

        private void btnMyDevices_Click(object sender, EventArgs e)
        {
            panViewPlaceholder.Controls.Clear();
            panViewPlaceholder.Controls.Add(panels["devices"]);
            panViewPlaceholder.Invalidate();
        }
    }
}
