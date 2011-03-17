namespace iTunesAgent.UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miTrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTraySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssTrayMyDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTrayPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTraySeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tssTraySynchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSynchronizeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSynchronizeSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tssSynchronizeNoDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslITunesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panMainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnMyDevices = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panViewPlaceholder = new System.Windows.Forms.Panel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.trayContextMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTrayExit,
            this.tssTraySeparator1,
            this.tssTrayMyDevices,
            this.tssTrayPreferences,
            this.tssTraySeparator2,
            this.tssTraySynchronize});
            this.trayContextMenu.Name = "trayContextMenu";
            resources.ApplyResources(this.trayContextMenu, "trayContextMenu");
            // 
            // miTrayExit
            // 
            this.miTrayExit.BackColor = System.Drawing.SystemColors.Control;
            this.miTrayExit.Name = "miTrayExit";
            resources.ApplyResources(this.miTrayExit, "miTrayExit");
            this.miTrayExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tssTraySeparator1
            // 
            this.tssTraySeparator1.Name = "tssTraySeparator1";
            resources.ApplyResources(this.tssTraySeparator1, "tssTraySeparator1");
            // 
            // tssTrayMyDevices
            // 
            this.tssTrayMyDevices.Name = "tssTrayMyDevices";
            resources.ApplyResources(this.tssTrayMyDevices, "tssTrayMyDevices");
            // 
            // tssTrayPreferences
            // 
            this.tssTrayPreferences.Name = "tssTrayPreferences";
            resources.ApplyResources(this.tssTrayPreferences, "tssTrayPreferences");
            // 
            // tssTraySeparator2
            // 
            this.tssTraySeparator2.Name = "tssTraySeparator2";
            resources.ApplyResources(this.tssTraySeparator2, "tssTraySeparator2");
            // 
            // tssTraySynchronize
            // 
            this.tssTraySynchronize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSynchronizeAll,
            this.tssSynchronizeSeparator1,
            this.tssSynchronizeNoDevices});
            this.tssTraySynchronize.Name = "tssTraySynchronize";
            resources.ApplyResources(this.tssTraySynchronize, "tssTraySynchronize");
            // 
            // tssSynchronizeAll
            // 
            this.tssSynchronizeAll.Name = "tssSynchronizeAll";
            resources.ApplyResources(this.tssSynchronizeAll, "tssSynchronizeAll");
            // 
            // tssSynchronizeSeparator1
            // 
            this.tssSynchronizeSeparator1.Name = "tssSynchronizeSeparator1";
            resources.ApplyResources(this.tssSynchronizeSeparator1, "tssSynchronizeSeparator1");
            // 
            // tssSynchronizeNoDevices
            // 
            resources.ApplyResources(this.tssSynchronizeNoDevices, "tssSynchronizeNoDevices");
            this.tssSynchronizeNoDevices.Name = "tssSynchronizeNoDevices";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslITunesStatus});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // tslITunesStatus
            // 
            this.tslITunesStatus.Name = "tslITunesStatus";
            resources.ApplyResources(this.tslITunesStatus, "tslITunesStatus");
            this.tslITunesStatus.Spring = true;
            // 
            // panMainPanel
            // 
            this.panMainPanel.Controls.Add(this.splitContainer);
            resources.ApplyResources(this.panMainPanel, "panMainPanel");
            this.panMainPanel.Name = "panMainPanel";
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panButtons);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panViewPlaceholder);
            // 
            // panButtons
            // 
            resources.ApplyResources(this.panButtons, "panButtons");
            this.panButtons.BackColor = System.Drawing.Color.White;
            this.panButtons.Controls.Add(this.btnPreferences);
            this.panButtons.Controls.Add(this.btnMyDevices);
            this.panButtons.Controls.Add(this.buttonHome);
            this.panButtons.Name = "panButtons";
            // 
            // btnPreferences
            // 
            resources.ApplyResources(this.btnPreferences, "btnPreferences");
            this.btnPreferences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreferences.FlatAppearance.BorderSize = 0;
            this.btnPreferences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPreferences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPreferences.Image = global::iTunesAgent.UI.Properties.Resources.preferences;
            this.btnPreferences.Name = "btnPreferences";
            this.toolTipMain.SetToolTip(this.btnPreferences, resources.GetString("btnPreferences.ToolTip"));
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnMyDevices
            // 
            resources.ApplyResources(this.btnMyDevices, "btnMyDevices");
            this.btnMyDevices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDevices.FlatAppearance.BorderSize = 0;
            this.btnMyDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMyDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMyDevices.Image = global::iTunesAgent.UI.Properties.Resources.media_players;
            this.btnMyDevices.Name = "btnMyDevices";
            this.toolTipMain.SetToolTip(this.btnMyDevices, resources.GetString("btnMyDevices.ToolTip"));
            this.btnMyDevices.UseVisualStyleBackColor = true;
            this.btnMyDevices.Click += new System.EventHandler(this.btnMyDevices_Click);
            // 
            // buttonHome
            // 
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonHome.Image = global::iTunesAgent.UI.Properties.Resources.home;
            this.buttonHome.Name = "buttonHome";
            this.toolTipMain.SetToolTip(this.buttonHome, resources.GetString("buttonHome.ToolTip"));
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panViewPlaceholder
            // 
            resources.ApplyResources(this.panViewPlaceholder, "panViewPlaceholder");
            this.panViewPlaceholder.Name = "panViewPlaceholder";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panMainPanel);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayContextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panMainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem miTrayExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panMainPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panViewPlaceholder;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.ToolStripStatusLabel tslITunesStatus;
        private System.Windows.Forms.ToolStripSeparator tssTraySeparator1;
        private System.Windows.Forms.ToolStripMenuItem tssTrayMyDevices;
        private System.Windows.Forms.ToolStripMenuItem tssTrayPreferences;
        private System.Windows.Forms.ToolStripMenuItem tssTraySynchronize;
        private System.Windows.Forms.ToolStripSeparator tssTraySeparator2;
        private System.Windows.Forms.ToolStripMenuItem tssSynchronizeAll;
        private System.Windows.Forms.ToolStripSeparator tssSynchronizeSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tssSynchronizeNoDevices;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnMyDevices;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

