namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceTypeSelectionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDeviceTypeSelectionPage));
            this.labelInfoTop = new System.Windows.Forms.Label();
            this.radioMassStorage = new System.Windows.Forms.RadioButton();
            this.labelMassStorageInfo = new System.Windows.Forms.Label();
            this.radioWindowsPortableDevice = new System.Windows.Forms.RadioButton();
            this.labelWPDInfo = new System.Windows.Forms.Label();
            this.labelMoreHelp = new System.Windows.Forms.Label();
            this.linkMoreHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelInfoTop
            // 
            this.labelInfoTop.Location = new System.Drawing.Point(3, 10);
            this.labelInfoTop.Name = "labelInfoTop";
            this.labelInfoTop.Size = new System.Drawing.Size(428, 18);
            this.labelInfoTop.TabIndex = 0;
            this.labelInfoTop.Text = "Please choose what type of device you have:";
            // 
            // radioMassStorage
            // 
            this.radioMassStorage.AutoSize = true;
            this.radioMassStorage.Checked = true;
            this.radioMassStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMassStorage.Location = new System.Drawing.Point(6, 42);
            this.radioMassStorage.Name = "radioMassStorage";
            this.radioMassStorage.Size = new System.Drawing.Size(180, 17);
            this.radioMassStorage.TabIndex = 1;
            this.radioMassStorage.TabStop = true;
            this.radioMassStorage.Text = "Removable Storage Device";
            this.radioMassStorage.UseVisualStyleBackColor = true;
            // 
            // labelMassStorageInfo
            // 
            this.labelMassStorageInfo.Location = new System.Drawing.Point(25, 66);
            this.labelMassStorageInfo.Name = "labelMassStorageInfo";
            this.labelMassStorageInfo.Size = new System.Drawing.Size(406, 48);
            this.labelMassStorageInfo.TabIndex = 2;
            this.labelMassStorageInfo.Text = "A Removable Storage Device is one treated as an external storage device by your c" +
                "omputer. It usually shows up as \"Removable disk\" with a drive letter, such as D:" +
                "\\, under My Computer.\r\n";
            // 
            // radioWindowsPortableDevice
            // 
            this.radioWindowsPortableDevice.AutoSize = true;
            this.radioWindowsPortableDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWindowsPortableDevice.Location = new System.Drawing.Point(6, 152);
            this.radioWindowsPortableDevice.Name = "radioWindowsPortableDevice";
            this.radioWindowsPortableDevice.Size = new System.Drawing.Size(154, 17);
            this.radioWindowsPortableDevice.TabIndex = 3;
            this.radioWindowsPortableDevice.Text = "Portable Media Device";
            this.radioWindowsPortableDevice.UseVisualStyleBackColor = true;
            // 
            // labelWPDInfo
            // 
            this.labelWPDInfo.Location = new System.Drawing.Point(25, 176);
            this.labelWPDInfo.Name = "labelWPDInfo";
            this.labelWPDInfo.Size = new System.Drawing.Size(406, 62);
            this.labelWPDInfo.TabIndex = 4;
            this.labelWPDInfo.Text = resources.GetString("labelWPDInfo.Text");
            // 
            // labelMoreHelp
            // 
            this.labelMoreHelp.AutoSize = true;
            this.labelMoreHelp.Location = new System.Drawing.Point(61, 275);
            this.labelMoreHelp.Name = "labelMoreHelp";
            this.labelMoreHelp.Size = new System.Drawing.Size(313, 13);
            this.labelMoreHelp.TabIndex = 5;
            this.labelMoreHelp.Text = "Need more help deciding what\'s the right choice for your device?";
            // 
            // linkMoreHelp
            // 
            this.linkMoreHelp.AutoSize = true;
            this.linkMoreHelp.Location = new System.Drawing.Point(156, 292);
            this.linkMoreHelp.Name = "linkMoreHelp";
            this.linkMoreHelp.Size = new System.Drawing.Size(123, 13);
            this.linkMoreHelp.TabIndex = 6;
            this.linkMoreHelp.TabStop = true;
            this.linkMoreHelp.Text = "Click here for online help";
            // 
            // NewDeviceTypeSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkMoreHelp);
            this.Controls.Add(this.labelMoreHelp);
            this.Controls.Add(this.labelWPDInfo);
            this.Controls.Add(this.radioWindowsPortableDevice);
            this.Controls.Add(this.labelMassStorageInfo);
            this.Controls.Add(this.radioMassStorage);
            this.Controls.Add(this.labelInfoTop);
            this.Name = "NewDeviceTypeSelectionPage";
            this.Size = new System.Drawing.Size(434, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTop;
        private System.Windows.Forms.RadioButton radioMassStorage;
        private System.Windows.Forms.Label labelMassStorageInfo;
        private System.Windows.Forms.RadioButton radioWindowsPortableDevice;
        private System.Windows.Forms.Label labelWPDInfo;
        private System.Windows.Forms.Label labelMoreHelp;
        private System.Windows.Forms.LinkLabel linkMoreHelp;
    }
}
