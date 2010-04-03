namespace iTunesAgent.UI
{
    partial class PreferencesPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesPanel));
            this.panContainer = new System.Windows.Forms.Panel();
            this.panGroups = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.gbBehaviour = new System.Windows.Forms.GroupBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.cbWarnSystemDrive = new System.Windows.Forms.CheckBox();
            this.cbBaloonNotifications = new System.Windows.Forms.CheckBox();
            this.gbITunes = new System.Windows.Forms.GroupBox();
            this.cbAutoExitWithITunes = new System.Windows.Forms.CheckBox();
            this.cbOrganizeInFolder = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panContainer.SuspendLayout();
            this.panGroups.SuspendLayout();
            this.gbBehaviour.SuspendLayout();
            this.gbITunes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.AutoScroll = true;
            this.panContainer.Controls.Add(this.panGroups);
            this.panContainer.Controls.Add(this.lblTitle);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(0, 0);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(499, 349);
            this.panContainer.TabIndex = 0;
            // 
            // panGroups
            // 
            this.panGroups.Controls.Add(this.buttonReset);
            this.panGroups.Controls.Add(this.buttonSave);
            this.panGroups.Controls.Add(this.gbBehaviour);
            this.panGroups.Controls.Add(this.gbITunes);
            this.panGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGroups.Location = new System.Drawing.Point(0, 50);
            this.panGroups.Name = "panGroups";
            this.panGroups.Padding = new System.Windows.Forms.Padding(3);
            this.panGroups.Size = new System.Drawing.Size(499, 299);
            this.panGroups.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(98, 265);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 28);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Reset back to previously saved preferences.");
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(5, 265);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 28);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.toolTip.SetToolTip(this.buttonSave, "Save your preferences.");
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // gbBehaviour
            // 
            this.gbBehaviour.Controls.Add(this.cbCheckForUpdates);
            this.gbBehaviour.Controls.Add(this.cbWarnSystemDrive);
            this.gbBehaviour.Controls.Add(this.cbBaloonNotifications);
            this.gbBehaviour.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBehaviour.Location = new System.Drawing.Point(3, 75);
            this.gbBehaviour.Name = "gbBehaviour";
            this.gbBehaviour.Size = new System.Drawing.Size(493, 73);
            this.gbBehaviour.TabIndex = 7;
            this.gbBehaviour.TabStop = false;
            this.gbBehaviour.Text = "Behaviour";
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(6, 42);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(177, 17);
            this.cbCheckForUpdates.TabIndex = 9;
            this.cbCheckForUpdates.Text = "Check for updates automatically";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // cbWarnSystemDrive
            // 
            this.cbWarnSystemDrive.AutoSize = true;
            this.cbWarnSystemDrive.Location = new System.Drawing.Point(216, 19);
            this.cbWarnSystemDrive.Name = "cbWarnSystemDrive";
            this.cbWarnSystemDrive.Size = new System.Drawing.Size(212, 17);
            this.cbWarnSystemDrive.TabIndex = 8;
            this.cbWarnSystemDrive.Text = "Warn if device looks like a system drive";
            this.toolTip.SetToolTip(this.cbWarnSystemDrive, resources.GetString("cbWarnSystemDrive.ToolTip"));
            this.cbWarnSystemDrive.UseVisualStyleBackColor = true;
            // 
            // cbBaloonNotifications
            // 
            this.cbBaloonNotifications.AutoSize = true;
            this.cbBaloonNotifications.Location = new System.Drawing.Point(6, 19);
            this.cbBaloonNotifications.Name = "cbBaloonNotifications";
            this.cbBaloonNotifications.Size = new System.Drawing.Size(189, 17);
            this.cbBaloonNotifications.TabIndex = 7;
            this.cbBaloonNotifications.Text = "Use baloon notifications for events";
            this.toolTip.SetToolTip(this.cbBaloonNotifications, "When checked, iTunes Agent will show notifications in the system tray on events s" +
                    "uch as connected/disconnected devices, synchronization status etc.");
            this.cbBaloonNotifications.UseVisualStyleBackColor = true;
            // 
            // gbITunes
            // 
            this.gbITunes.Controls.Add(this.cbAutoExitWithITunes);
            this.gbITunes.Controls.Add(this.cbOrganizeInFolder);
            this.gbITunes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbITunes.Location = new System.Drawing.Point(3, 3);
            this.gbITunes.Name = "gbITunes";
            this.gbITunes.Size = new System.Drawing.Size(493, 72);
            this.gbITunes.TabIndex = 6;
            this.gbITunes.TabStop = false;
            this.gbITunes.Text = "iTunes";
            // 
            // cbAutoExitWithITunes
            // 
            this.cbAutoExitWithITunes.AutoSize = true;
            this.cbAutoExitWithITunes.Location = new System.Drawing.Point(6, 45);
            this.cbAutoExitWithITunes.Name = "cbAutoExitWithITunes";
            this.cbAutoExitWithITunes.Size = new System.Drawing.Size(292, 17);
            this.cbAutoExitWithITunes.TabIndex = 6;
            this.cbAutoExitWithITunes.Text = "Automatically close iTunes Agent when iTunes is closing";
            this.cbAutoExitWithITunes.UseVisualStyleBackColor = true;
            // 
            // cbOrganizeInFolder
            // 
            this.cbOrganizeInFolder.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbOrganizeInFolder.Location = new System.Drawing.Point(6, 19);
            this.cbOrganizeInFolder.Name = "cbOrganizeInFolder";
            this.cbOrganizeInFolder.Size = new System.Drawing.Size(473, 20);
            this.cbOrganizeInFolder.TabIndex = 5;
            this.cbOrganizeInFolder.Text = "Organize custom playlists in iTunes in an \'iTunes Agent\' folder";
            this.cbOrganizeInFolder.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip.SetToolTip(this.cbOrganizeInFolder, "If checked, iTunes Agent will organize all playlists associated with your device " +
                    "under one top level folder named \'iTunes Agent\'. This may be preferrable if you " +
                    "have a lot of playlists and devices.");
            this.cbOrganizeInFolder.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Image = global::iTunesAgent.UI.Properties.Resources.preferences;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle.Size = new System.Drawing.Size(499, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Preferences";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreferencesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panContainer);
            this.Name = "PreferencesPanel";
            this.Size = new System.Drawing.Size(499, 349);
            this.Load += new System.EventHandler(this.PreferencesPanel_Load);
            this.panContainer.ResumeLayout(false);
            this.panGroups.ResumeLayout(false);
            this.gbBehaviour.ResumeLayout(false);
            this.gbBehaviour.PerformLayout();
            this.gbITunes.ResumeLayout(false);
            this.gbITunes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panGroups;
        private System.Windows.Forms.GroupBox gbBehaviour;
        private System.Windows.Forms.CheckBox cbWarnSystemDrive;
        private System.Windows.Forms.CheckBox cbBaloonNotifications;
        private System.Windows.Forms.GroupBox gbITunes;
        private System.Windows.Forms.CheckBox cbAutoExitWithITunes;
        private System.Windows.Forms.CheckBox cbOrganizeInFolder;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
    }
}
