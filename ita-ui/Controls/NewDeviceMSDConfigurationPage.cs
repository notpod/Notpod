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
    public partial class NewDeviceMSDConfigurationPage : AbstractWizardPage
    {
        public NewDeviceMSDConfigurationPage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            string fullPath = (string)DataStore["msdFullPath"];
            if (!String.IsNullOrEmpty(fullPath))
            {
                labelDeviceMusicLocation.Text = fullPath;
            }
        }

        public override bool ValidateBeforeNext()
        {

            return base.ValidateBeforeNext();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog deviceBrowser = new FolderBrowserDialog();
            DialogResult result = deviceBrowser.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            string fullPath = deviceBrowser.SelectedPath;
            string drive = fullPath.Substring(0, 2);
            string path = fullPath.Substring(2);
            labelDeviceMusicLocation.Text = fullPath;

            DataStore["msdFullPath"] = fullPath;
            DataStore["msdPathOnDevice"] = path;
        }

    }
}
