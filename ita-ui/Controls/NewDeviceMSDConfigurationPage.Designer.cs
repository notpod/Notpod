namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceMSDConfigurationPage
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
            this.labelInfoTop = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelSelectedLocationInfo = new System.Windows.Forms.Label();
            this.labelDeviceMusicLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfoTop
            // 
            this.labelInfoTop.AutoSize = true;
            this.labelInfoTop.Location = new System.Drawing.Point(4, 4);
            this.labelInfoTop.Name = "labelInfoTop";
            this.labelInfoTop.Size = new System.Drawing.Size(262, 13);
            this.labelInfoTop.TabIndex = 0;
            this.labelInfoTop.Text = "Please choose the disk drive that is your media player:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(3, 29);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(506, 34);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "&Click to browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelSelectedLocationInfo
            // 
            this.labelSelectedLocationInfo.AutoSize = true;
            this.labelSelectedLocationInfo.Location = new System.Drawing.Point(3, 77);
            this.labelSelectedLocationInfo.Name = "labelSelectedLocationInfo";
            this.labelSelectedLocationInfo.Size = new System.Drawing.Size(100, 13);
            this.labelSelectedLocationInfo.TabIndex = 2;
            this.labelSelectedLocationInfo.Text = "Selected disk drive:";
            // 
            // labelDeviceMusicLocation
            // 
            this.labelDeviceMusicLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceMusicLocation.ForeColor = System.Drawing.Color.Gray;
            this.labelDeviceMusicLocation.Location = new System.Drawing.Point(16, 104);
            this.labelDeviceMusicLocation.Name = "labelDeviceMusicLocation";
            this.labelDeviceMusicLocation.Size = new System.Drawing.Size(483, 98);
            this.labelDeviceMusicLocation.TabIndex = 3;
            this.labelDeviceMusicLocation.Text = "None selected yet.";
            // 
            // NewDeviceMSDConfigurationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDeviceMusicLocation);
            this.Controls.Add(this.labelSelectedLocationInfo);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.labelInfoTop);
            this.Name = "NewDeviceMSDConfigurationPage";
            this.Size = new System.Drawing.Size(512, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTop;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelSelectedLocationInfo;
        private System.Windows.Forms.Label labelDeviceMusicLocation;
    }
}
