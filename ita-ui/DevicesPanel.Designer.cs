namespace iTunesAgent.UI
{
    partial class DevicesPanel
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
            this.panContainer = new System.Windows.Forms.Panel();
            this.layoutTableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.chDeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeviceStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeviceFreeSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeviceLastSync = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteDevice = new System.Windows.Forms.Button();
            this.btnEditDevice = new System.Windows.Forms.Button();
            this.btnNewDevice = new System.Windows.Forms.Button();
            this.lblMyDevices = new System.Windows.Forms.Label();
            this.panContainer.SuspendLayout();
            this.layoutTableMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panContainer
            // 
            this.panContainer.Controls.Add(this.layoutTableMain);
            this.panContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContainer.Location = new System.Drawing.Point(0, 0);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(636, 358);
            this.panContainer.TabIndex = 0;
            // 
            // layoutTableMain
            // 
            this.layoutTableMain.ColumnCount = 1;
            this.layoutTableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTableMain.Controls.Add(this.panel1, 0, 1);
            this.layoutTableMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.layoutTableMain.Controls.Add(this.lblMyDevices, 0, 0);
            this.layoutTableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTableMain.Location = new System.Drawing.Point(0, 0);
            this.layoutTableMain.Name = "layoutTableMain";
            this.layoutTableMain.RowCount = 3;
            this.layoutTableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutTableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutTableMain.Size = new System.Drawing.Size(636, 358);
            this.layoutTableMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvDevices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 262);
            this.panel1.TabIndex = 0;
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDeviceName,
            this.chDeviceStatus,
            this.chDeviceFreeSpace,
            this.chDeviceLastSync});
            this.lvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDevices.FullRowSelect = true;
            this.lvDevices.GridLines = true;
            this.lvDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(0, 0);
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(630, 262);
            this.lvDevices.TabIndex = 7;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // chDeviceName
            // 
            this.chDeviceName.Text = "Name";
            this.chDeviceName.Width = 200;
            // 
            // chDeviceStatus
            // 
            this.chDeviceStatus.Text = "Status";
            this.chDeviceStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDeviceStatus.Width = 100;
            // 
            // chDeviceFreeSpace
            // 
            this.chDeviceFreeSpace.Text = "Free space";
            this.chDeviceFreeSpace.Width = 80;
            // 
            // chDeviceLastSync
            // 
            this.chDeviceLastSync.Text = "Last sync";
            this.chDeviceLastSync.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteDevice, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditDevice, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNewDevice, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 321);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnDeleteDevice
            // 
            this.btnDeleteDevice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteDevice.Location = new System.Drawing.Point(550, 3);
            this.btnDeleteDevice.Name = "btnDeleteDevice";
            this.btnDeleteDevice.Size = new System.Drawing.Size(77, 28);
            this.btnDeleteDevice.TabIndex = 0;
            this.btnDeleteDevice.Text = "Delete";
            this.btnDeleteDevice.UseVisualStyleBackColor = true;
            this.btnDeleteDevice.Click += new System.EventHandler(this.btnDeleteDevice_Click);
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.Location = new System.Drawing.Point(88, 3);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(74, 28);
            this.btnEditDevice.TabIndex = 1;
            this.btnEditDevice.Text = "Edit";
            this.btnEditDevice.UseVisualStyleBackColor = true;
            // 
            // btnNewDevice
            // 
            this.btnNewDevice.Location = new System.Drawing.Point(3, 3);
            this.btnNewDevice.Name = "btnNewDevice";
            this.btnNewDevice.Size = new System.Drawing.Size(74, 28);
            this.btnNewDevice.TabIndex = 2;
            this.btnNewDevice.Text = "New device";
            this.btnNewDevice.UseVisualStyleBackColor = true;
            this.btnNewDevice.Click += new System.EventHandler(this.btnNewDevice_Click);
            // 
            // lblMyDevices
            // 
            this.lblMyDevices.AutoSize = true;
            this.lblMyDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDevices.Image = global::iTunesAgent.UI.Properties.Resources.media_players;
            this.lblMyDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMyDevices.Location = new System.Drawing.Point(5, 0);
            this.lblMyDevices.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lblMyDevices.Name = "lblMyDevices";
            this.lblMyDevices.Size = new System.Drawing.Size(628, 50);
            this.lblMyDevices.TabIndex = 2;
            this.lblMyDevices.Text = "My devices";
            this.lblMyDevices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevicesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panContainer);
            this.Name = "DevicesPanel";
            this.Size = new System.Drawing.Size(636, 358);
            this.Load += new System.EventHandler(this.DevicesPanel_Load);
            this.panContainer.ResumeLayout(false);
            this.layoutTableMain.ResumeLayout(false);
            this.layoutTableMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panContainer;
        private System.Windows.Forms.TableLayoutPanel layoutTableMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader chDeviceName;
        private System.Windows.Forms.ColumnHeader chDeviceStatus;
        private System.Windows.Forms.ColumnHeader chDeviceFreeSpace;
        private System.Windows.Forms.ColumnHeader chDeviceLastSync;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDeleteDevice;
        private System.Windows.Forms.Button btnEditDevice;
        private System.Windows.Forms.Button btnNewDevice;
        private System.Windows.Forms.Label lblMyDevices;

    }
}
