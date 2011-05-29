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
            this.labelLocationInfo = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
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
            // labelLocationInfo
            // 
            this.labelLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationInfo.Location = new System.Drawing.Point(3, 57);
            this.labelLocationInfo.Name = "labelLocationInfo";
            this.labelLocationInfo.Size = new System.Drawing.Size(128, 17);
            this.labelLocationInfo.TabIndex = 5;
            this.labelLocationInfo.Text = "Location:";
            // 
            // labelLocation
            // 
            this.labelLocation.Location = new System.Drawing.Point(16, 74);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(457, 53);
            this.labelLocation.TabIndex = 6;
            this.labelLocation.Text = "Location";
            // 
            // NewDeviceSummaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelLocationInfo);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.labelDeviceNameInfo);
            this.Controls.Add(this.labelExplanation);
            this.Name = "NewDeviceSummaryPage";
            this.Size = new System.Drawing.Size(476, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Label labelDeviceNameInfo;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.Label labelLocationInfo;
        private System.Windows.Forms.Label labelLocation;
    }
}
