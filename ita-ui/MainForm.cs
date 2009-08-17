using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ita_ui
{
    public partial class MainForm : Form
    {
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
            panViewPlaceholder.Controls.Add(panels["devices"]);
        }

        private void InitializePanels()
        {
            panels.Add("devices", new DevicesPanel());
        }
    }
}
