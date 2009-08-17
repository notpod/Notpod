namespace ita_ui
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panMainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panViewPlaceholder = new System.Windows.Forms.Panel();
            this.btnMyDevices = new System.Windows.Forms.Button();
            this.panButtons = new System.Windows.Forms.Panel();
            this.trayContextMenu.SuspendLayout();
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
            this.trayIcon.Text = "iTunes Agent";
            this.trayIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTrayExit});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(144, 26);
            // 
            // miTrayExit
            // 
            this.miTrayExit.BackColor = System.Drawing.SystemColors.Control;
            this.miTrayExit.Name = "miTrayExit";
            this.miTrayExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.miTrayExit.Size = new System.Drawing.Size(143, 22);
            this.miTrayExit.Text = "E&xit";
            this.miTrayExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 483);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(762, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // panMainPanel
            // 
            this.panMainPanel.Controls.Add(this.splitContainer);
            this.panMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panMainPanel.Name = "panMainPanel";
            this.panMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.panMainPanel.Size = new System.Drawing.Size(762, 483);
            this.panMainPanel.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
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
            this.splitContainer.Size = new System.Drawing.Size(752, 473);
            this.splitContainer.SplitterDistance = 92;
            this.splitContainer.TabIndex = 5;
            // 
            // panViewPlaceholder
            // 
            this.panViewPlaceholder.AutoSize = true;
            this.panViewPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panViewPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.panViewPlaceholder.Name = "panViewPlaceholder";
            this.panViewPlaceholder.Size = new System.Drawing.Size(656, 473);
            this.panViewPlaceholder.TabIndex = 6;
            // 
            // btnMyDevices
            // 
            this.btnMyDevices.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMyDevices.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMyDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyDevices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMyDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMyDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDevices.Image = global::ita_ui.Properties.Resources.devices_icon;
            this.btnMyDevices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMyDevices.Location = new System.Drawing.Point(0, 0);
            this.btnMyDevices.Name = "btnMyDevices";
            this.btnMyDevices.Size = new System.Drawing.Size(92, 64);
            this.btnMyDevices.TabIndex = 0;
            this.btnMyDevices.Text = "My Devices";
            this.btnMyDevices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMyDevices.UseVisualStyleBackColor = true;
            // 
            // panButtons
            // 
            this.panButtons.AutoSize = true;
            this.panButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panButtons.Controls.Add(this.btnMyDevices);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panButtons.Location = new System.Drawing.Point(0, 0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(92, 473);
            this.panButtons.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 505);
            this.Controls.Add(this.panMainPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "iTunes Agent";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayContextMenu.ResumeLayout(false);
            this.panMainPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnMyDevices;
    }
}

