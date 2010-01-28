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
            this.gbUserInterface = new System.Windows.Forms.GroupBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
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
            this.gbUserInterface.SuspendLayout();
            this.gbBehaviour.SuspendLayout();
            this.gbITunes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.AccessibleDescription = null;
            this.panContainer.AccessibleName = null;
            resources.ApplyResources(this.panContainer, "panContainer");
            this.panContainer.BackgroundImage = null;
            this.panContainer.Controls.Add(this.panGroups);
            this.panContainer.Controls.Add(this.lblTitle);
            this.panContainer.Font = null;
            this.panContainer.Name = "panContainer";
            this.toolTip.SetToolTip(this.panContainer, resources.GetString("panContainer.ToolTip"));
            // 
            // panGroups
            // 
            this.panGroups.AccessibleDescription = null;
            this.panGroups.AccessibleName = null;
            resources.ApplyResources(this.panGroups, "panGroups");
            this.panGroups.BackgroundImage = null;
            this.panGroups.Controls.Add(this.gbUserInterface);
            this.panGroups.Controls.Add(this.buttonReset);
            this.panGroups.Controls.Add(this.buttonSave);
            this.panGroups.Controls.Add(this.gbBehaviour);
            this.panGroups.Controls.Add(this.gbITunes);
            this.panGroups.Font = null;
            this.panGroups.Name = "panGroups";
            this.toolTip.SetToolTip(this.panGroups, resources.GetString("panGroups.ToolTip"));
            // 
            // gbUserInterface
            // 
            this.gbUserInterface.AccessibleDescription = null;
            this.gbUserInterface.AccessibleName = null;
            resources.ApplyResources(this.gbUserInterface, "gbUserInterface");
            this.gbUserInterface.BackgroundImage = null;
            this.gbUserInterface.Controls.Add(this.labelLanguage);
            this.gbUserInterface.Controls.Add(this.cbxLanguage);
            this.gbUserInterface.Font = null;
            this.gbUserInterface.Name = "gbUserInterface";
            this.gbUserInterface.TabStop = false;
            this.toolTip.SetToolTip(this.gbUserInterface, resources.GetString("gbUserInterface.ToolTip"));
            // 
            // labelLanguage
            // 
            this.labelLanguage.AccessibleDescription = null;
            this.labelLanguage.AccessibleName = null;
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Font = null;
            this.labelLanguage.Name = "labelLanguage";
            this.toolTip.SetToolTip(this.labelLanguage, resources.GetString("labelLanguage.ToolTip"));
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.AccessibleDescription = null;
            this.cbxLanguage.AccessibleName = null;
            resources.ApplyResources(this.cbxLanguage, "cbxLanguage");
            this.cbxLanguage.BackgroundImage = null;
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.Font = null;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Name = "cbxLanguage";
            this.toolTip.SetToolTip(this.cbxLanguage, resources.GetString("cbxLanguage.ToolTip"));
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.AccessibleDescription = null;
            this.buttonReset.AccessibleName = null;
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.BackgroundImage = null;
            this.buttonReset.Font = null;
            this.buttonReset.Name = "buttonReset";
            this.toolTip.SetToolTip(this.buttonReset, resources.GetString("buttonReset.ToolTip"));
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.AccessibleDescription = null;
            this.buttonSave.AccessibleName = null;
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.BackgroundImage = null;
            this.buttonSave.Font = null;
            this.buttonSave.Name = "buttonSave";
            this.toolTip.SetToolTip(this.buttonSave, resources.GetString("buttonSave.ToolTip"));
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // gbBehaviour
            // 
            this.gbBehaviour.AccessibleDescription = null;
            this.gbBehaviour.AccessibleName = null;
            resources.ApplyResources(this.gbBehaviour, "gbBehaviour");
            this.gbBehaviour.BackgroundImage = null;
            this.gbBehaviour.Controls.Add(this.cbCheckForUpdates);
            this.gbBehaviour.Controls.Add(this.cbWarnSystemDrive);
            this.gbBehaviour.Controls.Add(this.cbBaloonNotifications);
            this.gbBehaviour.Font = null;
            this.gbBehaviour.Name = "gbBehaviour";
            this.gbBehaviour.TabStop = false;
            this.toolTip.SetToolTip(this.gbBehaviour, resources.GetString("gbBehaviour.ToolTip"));
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AccessibleDescription = null;
            this.cbCheckForUpdates.AccessibleName = null;
            resources.ApplyResources(this.cbCheckForUpdates, "cbCheckForUpdates");
            this.cbCheckForUpdates.BackgroundImage = null;
            this.cbCheckForUpdates.Font = null;
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.toolTip.SetToolTip(this.cbCheckForUpdates, resources.GetString("cbCheckForUpdates.ToolTip"));
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // cbWarnSystemDrive
            // 
            this.cbWarnSystemDrive.AccessibleDescription = null;
            this.cbWarnSystemDrive.AccessibleName = null;
            resources.ApplyResources(this.cbWarnSystemDrive, "cbWarnSystemDrive");
            this.cbWarnSystemDrive.BackgroundImage = null;
            this.cbWarnSystemDrive.Font = null;
            this.cbWarnSystemDrive.Name = "cbWarnSystemDrive";
            this.toolTip.SetToolTip(this.cbWarnSystemDrive, resources.GetString("cbWarnSystemDrive.ToolTip"));
            this.cbWarnSystemDrive.UseVisualStyleBackColor = true;
            // 
            // cbBaloonNotifications
            // 
            this.cbBaloonNotifications.AccessibleDescription = null;
            this.cbBaloonNotifications.AccessibleName = null;
            resources.ApplyResources(this.cbBaloonNotifications, "cbBaloonNotifications");
            this.cbBaloonNotifications.BackgroundImage = null;
            this.cbBaloonNotifications.Font = null;
            this.cbBaloonNotifications.Name = "cbBaloonNotifications";
            this.toolTip.SetToolTip(this.cbBaloonNotifications, resources.GetString("cbBaloonNotifications.ToolTip"));
            this.cbBaloonNotifications.UseVisualStyleBackColor = true;
            // 
            // gbITunes
            // 
            this.gbITunes.AccessibleDescription = null;
            this.gbITunes.AccessibleName = null;
            resources.ApplyResources(this.gbITunes, "gbITunes");
            this.gbITunes.BackgroundImage = null;
            this.gbITunes.Controls.Add(this.cbAutoExitWithITunes);
            this.gbITunes.Controls.Add(this.cbOrganizeInFolder);
            this.gbITunes.Font = null;
            this.gbITunes.Name = "gbITunes";
            this.gbITunes.TabStop = false;
            this.toolTip.SetToolTip(this.gbITunes, resources.GetString("gbITunes.ToolTip"));
            // 
            // cbAutoExitWithITunes
            // 
            this.cbAutoExitWithITunes.AccessibleDescription = null;
            this.cbAutoExitWithITunes.AccessibleName = null;
            resources.ApplyResources(this.cbAutoExitWithITunes, "cbAutoExitWithITunes");
            this.cbAutoExitWithITunes.BackgroundImage = null;
            this.cbAutoExitWithITunes.Font = null;
            this.cbAutoExitWithITunes.Name = "cbAutoExitWithITunes";
            this.toolTip.SetToolTip(this.cbAutoExitWithITunes, resources.GetString("cbAutoExitWithITunes.ToolTip"));
            this.cbAutoExitWithITunes.UseVisualStyleBackColor = true;
            // 
            // cbOrganizeInFolder
            // 
            this.cbOrganizeInFolder.AccessibleDescription = null;
            this.cbOrganizeInFolder.AccessibleName = null;
            resources.ApplyResources(this.cbOrganizeInFolder, "cbOrganizeInFolder");
            this.cbOrganizeInFolder.BackgroundImage = null;
            this.cbOrganizeInFolder.Font = null;
            this.cbOrganizeInFolder.Name = "cbOrganizeInFolder";
            this.toolTip.SetToolTip(this.cbOrganizeInFolder, resources.GetString("cbOrganizeInFolder.ToolTip"));
            this.cbOrganizeInFolder.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleDescription = null;
            this.lblTitle.AccessibleName = null;
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Image = global::iTunesAgent.UI.Properties.Resources.preferences;
            this.lblTitle.Name = "lblTitle";
            this.toolTip.SetToolTip(this.lblTitle, resources.GetString("lblTitle.ToolTip"));
            // 
            // PreferencesPanel
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.panContainer);
            this.Font = null;
            this.Name = "PreferencesPanel";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.panContainer.ResumeLayout(false);
            this.panGroups.ResumeLayout(false);
            this.gbUserInterface.ResumeLayout(false);
            this.gbUserInterface.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbUserInterface;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ComboBox cbxLanguage;
    }
}
