namespace ita_ui
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
            this.lvDevices = new System.Windows.Forms.ListView();
            this.chDeviceName = new System.Windows.Forms.ColumnHeader();
            this.chDeviceStatus = new System.Windows.Forms.ColumnHeader();
            this.chDeviceFreeSpace = new System.Windows.Forms.ColumnHeader();
            this.chDeviceLastSync = new System.Windows.Forms.ColumnHeader();
            this.lblMyDevExplanation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDeviceName,
            this.chDeviceStatus,
            this.chDeviceFreeSpace,
            this.chDeviceLastSync});
            this.lvDevices.FullRowSelect = true;
            this.lvDevices.GridLines = true;
            this.lvDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(6, 43);
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(621, 282);
            this.lvDevices.TabIndex = 3;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // chDeviceName
            // 
            this.chDeviceName.Text = "Name";
            // 
            // chDeviceStatus
            // 
            this.chDeviceStatus.Text = "Status";
            // 
            // chDeviceFreeSpace
            // 
            this.chDeviceFreeSpace.Text = "Free space";
            // 
            // chDeviceLastSync
            // 
            this.chDeviceLastSync.Text = "Last sync";
            // 
            // lblMyDevExplanation
            // 
            this.lblMyDevExplanation.Location = new System.Drawing.Point(3, 9);
            this.lblMyDevExplanation.Name = "lblMyDevExplanation";
            this.lblMyDevExplanation.Size = new System.Drawing.Size(621, 31);
            this.lblMyDevExplanation.TabIndex = 2;
            this.lblMyDevExplanation.Text = "This list contains all your device configurations and whether the devices are con" +
                "nected or not. You may add new devices, edit existing and initiate device synchr" +
                "onizations from this view.";
            // 
            // DevicesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvDevices);
            this.Controls.Add(this.lblMyDevExplanation);
            this.Name = "DevicesPanel";
            this.Size = new System.Drawing.Size(636, 336);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader chDeviceName;
        private System.Windows.Forms.ColumnHeader chDeviceStatus;
        private System.Windows.Forms.ColumnHeader chDeviceFreeSpace;
        private System.Windows.Forms.ColumnHeader chDeviceLastSync;
        private System.Windows.Forms.Label lblMyDevExplanation;
    }
}
