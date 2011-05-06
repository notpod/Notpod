using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
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
            string fullPath = (string)DataStore["msdDrive"];
            if (!String.IsNullOrEmpty(fullPath))
            {
                labelDeviceMusicLocation.Text = fullPath;
            }
        }

        public override bool ValidateBeforeNext()
        {
            string fullPath = (string)DataStore["msdDrive"];
            if (String.IsNullOrEmpty(fullPath))
            {
                MessageBox.Show(this, "You must choose a disk drive, before continuing.", "Removable storage device configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
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
            string drive = fullPath.Substring(0, 1);

            DriveInfo driveInfo = new DriveInfo(drive);
            if (driveInfo.DriveType != DriveType.Removable)
            {
                if (MessageBox.Show(this, "You have selected drive " + drive + ": as your device.\n\nWindows says "
                    + "that this drive is not a removable storage. This check is done to prevent you from mistakenly "
                    + "configure one of your hard drives as your Removable storage device.\n\nIf you intentionally selected " 
                    + drive + ":, please click OK to continue. If not, please click Cancel and select a new drive.", "Please verify drive selection", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }

            labelDeviceMusicLocation.Text = drive + ":\\";
            DataStore["msdDrive"] = drive;
        }

    }
}
