namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceSummaryPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelExplanation = new System.Windows.Forms.Label();
            this.labelDeviceNameInfo = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.cbOpenPlaylistsPanelOnFinish = new System.Windows.Forms.CheckBox();
            this.labelPlaylistSetup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelExplanation
            // 
            this.labelExplanation.Location = new System.Drawing.Point(3, 0);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(470, 40);
            this.labelExplanation.TabIndex = 0;
            this.labelExplanation.Text = "Please take a minute to verify the information below. Click Finish if it is corre" +
                "ct, otherwise go back and correct the information.";
            // 
            // labelDeviceNameInfo
            // 
            this.labelDeviceNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceNameInfo.Location = new System.Drawing.Point(3, 40);
            this.labelDeviceNameInfo.Name = "labelDeviceNameInfo";
            this.labelDeviceNameInfo.Size = new System.Drawing.Size(128, 17);
            this.labelDeviceNameInfo.TabIndex = 1;
            this.labelDeviceNameInfo.Text = "Name:";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.Location = new System.Drawing.Point(137, 40);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(336, 17);
            this.labelDeviceName.TabIndex = 2;
            this.labelDeviceName.Text = "Device name";
            // 
            // cbOpenPlaylistsPanelOnFinish
            // 
            this.cbOpenPlaylistsPanelOnFinish.AutoSize = true;
            this.cbOpenPlaylistsPanelOnFinish.Checked = true;
            this.cbOpenPlaylistsPanelOnFinish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpenPlaylistsPanelOnFinish.Location = new System.Drawing.Point(6, 105);
            this.cbOpenPlaylistsPanelOnFinish.Name = "cbOpenPlaylistsPanelOnFinish";
            this.cbOpenPlaylistsPanelOnFinish.Size = new System.Drawing.Size(287, 17);
            this.cbOpenPlaylistsPanelOnFinish.TabIndex = 3;
            this.cbOpenPlaylistsPanelOnFinish.Text = "Yes, please open the paylist panel when I press \'Finish\'.";
            this.cbOpenPlaylistsPanelOnFinish.UseVisualStyleBackColor = true;
            // 
            // labelPlaylistSetup
            // 
            this.labelPlaylistSetup.AutoSize = true;
            this.labelPlaylistSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylistSetup.Location = new System.Drawing.Point(3, 89);
            this.labelPlaylistSetup.Name = "labelPlaylistSetup";
            this.labelPlaylistSetup.Size = new System.Drawing.Size(339, 13);
            this.labelPlaylistSetup.TabIndex = 4;
            this.labelPlaylistSetup.Text = "Do you want to set up playlists for your device right away?";
            // 
            // NewDeviceSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPlaylistSetup);
            this.Controls.Add(this.cbOpenPlaylistsPanelOnFinish);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.labelDeviceNameInfo);
            this.Controls.Add(this.labelExplanation);
            this.Name = "NewDeviceSummaryPage";
            this.Size = new System.Drawing.Size(476, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Label labelDeviceNameInfo;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.CheckBox cbOpenPlaylistsPanelOnFinish;
        private System.Windows.Forms.Label labelPlaylistSetup;
    }
}
