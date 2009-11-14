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
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "iTunes Agent";
            this.trayIcon.Visible = true;
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
            this.trayContextMenu.Size = new System.Drawing.Size(145, 104);
            // 
            // miTrayExit
            // 
            this.miTrayExit.BackColor = System.Drawing.SystemColors.Control;
            this.miTrayExit.Name = "miTrayExit";
            this.miTrayExit.Size = new System.Drawing.Size(144, 22);
            this.miTrayExit.Text = "E&xit";
            this.miTrayExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tssTraySeparator1
            // 
            this.tssTraySeparator1.Name = "tssTraySeparator1";
            this.tssTraySeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // tssTrayMyDevices
            // 
            this.tssTrayMyDevices.Name = "tssTrayMyDevices";
            this.tssTrayMyDevices.Size = new System.Drawing.Size(144, 22);
            this.tssTrayMyDevices.Text = "My devices...";
            // 
            // tssTrayPreferences
            // 
            this.tssTrayPreferences.Name = "tssTrayPreferences";
            this.tssTrayPreferences.Size = new System.Drawing.Size(144, 22);
            this.tssTrayPreferences.Text = "Preferences...";
            // 
            // tssTraySeparator2
            // 
            this.tssTraySeparator2.Name = "tssTraySeparator2";
            this.tssTraySeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // tssTraySynchronize
            // 
            this.tssTraySynchronize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSynchronizeAll,
            this.tssSynchronizeSeparator1,
            this.tssSynchronizeNoDevices});
            this.tssTraySynchronize.Name = "tssTraySynchronize";
            this.tssTraySynchronize.Size = new System.Drawing.Size(144, 22);
            this.tssTraySynchronize.Text = "Synchronize";
            // 
            // tssSynchronizeAll
            // 
            this.tssSynchronizeAll.Name = "tssSynchronizeAll";
            this.tssSynchronizeAll.Size = new System.Drawing.Size(132, 22);
            this.tssSynchronizeAll.Text = "All devices";
            // 
            // tssSynchronizeSeparator1
            // 
            this.tssSynchronizeSeparator1.Name = "tssSynchronizeSeparator1";
            this.tssSynchronizeSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // tssSynchronizeNoDevices
            // 
            this.tssSynchronizeNoDevices.Enabled = false;
            this.tssSynchronizeNoDevices.Name = "tssSynchronizeNoDevices";
            this.tssSynchronizeNoDevices.Size = new System.Drawing.Size(132, 22);
            this.tssSynchronizeNoDevices.Text = "No devices";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslITunesStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 400);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(674, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            // 
            // tslITunesStatus
            // 
            this.tslITunesStatus.Name = "tslITunesStatus";
            this.tslITunesStatus.Size = new System.Drawing.Size(649, 17);
            this.tslITunesStatus.Spring = true;
            this.tslITunesStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panMainPanel
            // 
            this.panMainPanel.Controls.Add(this.splitContainer);
            this.panMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panMainPanel.Name = "panMainPanel";
            this.panMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.panMainPanel.Size = new System.Drawing.Size(674, 400);
            this.panMainPanel.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(5, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panButtons);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panViewPlaceholder);
            this.splitContainer.Size = new System.Drawing.Size(664, 390);
            this.splitContainer.SplitterDistance = 92;
            this.splitContainer.TabIndex = 5;
            // 
            // panButtons
            // 
            this.panButtons.AutoSize = true;
            this.panButtons.BackColor = System.Drawing.Color.White;
            this.panButtons.Controls.Add(this.btnPreferences);
            this.panButtons.Controls.Add(this.btnMyDevices);
            this.panButtons.Controls.Add(this.buttonHome);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panButtons.Location = new System.Drawing.Point(0, 0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(92, 390);
            this.panButtons.TabIndex = 5;
            // 
            // btnPreferences
            // 
            this.btnPreferences.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPreferences.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreferences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPreferences.FlatAppearance.BorderSize = 0;
            this.btnPreferences.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPreferences.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnPreferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferences.Image = global::iTunesAgent.UI.Properties.Resources.preferences;
            this.btnPreferences.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreferences.Location = new System.Drawing.Point(0, 130);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(92, 64);
            this.btnPreferences.TabIndex = 5;
            this.btnPreferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMain.SetToolTip(this.btnPreferences, "Application preferences");
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnMyDevices
            // 
            this.btnMyDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMyDevices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyDevices.FlatAppearance.BorderSize = 0;
            this.btnMyDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMyDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMyDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDevices.Image = global::iTunesAgent.UI.Properties.Resources.media_players;
            this.btnMyDevices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMyDevices.Location = new System.Drawing.Point(0, 65);
            this.btnMyDevices.Name = "btnMyDevices";
            this.btnMyDevices.Size = new System.Drawing.Size(92, 65);
            this.btnMyDevices.TabIndex = 4;
            this.btnMyDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipMain.SetToolTip(this.btnMyDevices, "Manage my devices");
            this.btnMyDevices.UseVisualStyleBackColor = true;
            this.btnMyDevices.Click += new System.EventHandler(this.btnMyDevices_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Image = global::iTunesAgent.UI.Properties.Resources.home;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(92, 65);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTipMain.SetToolTip(this.buttonHome, "Home screen");
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panViewPlaceholder
            // 
            this.panViewPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panViewPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panViewPlaceholder.Name = "panViewPlaceholder";
            this.panViewPlaceholder.Size = new System.Drawing.Size(568, 390);
            this.panViewPlaceholder.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 422);
            this.Controls.Add(this.panMainPanel);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iTunes Agent";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayContextMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panMainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
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

