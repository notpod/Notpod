using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.Domain;

namespace iTunesAgent.UI
{
    public partial class NewPlaylistAssociationForm : Form
    {

        private ModelRepository model;

        public NewPlaylistAssociationForm()
        {
            InitializeComponent();
        }

        public ModelRepository Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private void NewPlaylistAssociationForm_Load(object sender, EventArgs e)
        {
            DeviceCollection devices = model.Get<DeviceCollection>("devices");
            foreach (Device device in devices.Devices) 
            {
                cbDeviceSelector.Items.Add(device);
            }

        }
    }
}
