namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceNamePage
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
            this.labelDeviceNameExplanation = new System.Windows.Forms.Label();
            this.textDeviceName = new System.Windows.Forms.TextBox();
            this.labelDeviceNameTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeviceNameExplanation
            // 
            this.labelDeviceNameExplanation.Location = new System.Drawing.Point(0, 7);
            this.labelDeviceNameExplanation.Name = "labelDeviceNameExplanation";
            this.labelDeviceNameExplanation.Size = new System.Drawing.Size(424, 21);
            this.labelDeviceNameExplanation.TabIndex = 0;
            this.labelDeviceNameExplanation.Text = "Please enter a name for your device.";
            // 
            // textDeviceName
            // 
            this.textDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDeviceName.Location = new System.Drawing.Point(3, 31);
            this.textDeviceName.Name = "textDeviceName";
            this.textDeviceName.Size = new System.Drawing.Size(428, 26);
            this.textDeviceName.TabIndex = 1;
            // 
            // labelDeviceNameTip
            // 
            this.labelDeviceNameTip.Location = new System.Drawing.Point(3, 78);
            this.labelDeviceNameTip.Name = "labelDeviceNameTip";
            this.labelDeviceNameTip.Size = new System.Drawing.Size(428, 132);
            this.labelDeviceNameTip.TabIndex = 2;
            this.labelDeviceNameTip.Text = "Tip: The name should be a unique and easily identifiable name. For instance, if y" +
                "our device is a Playstation Portable, a reasonable name would be \"My PSP\".";
            // 
            // NewDeviceNamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDeviceNameTip);
            this.Controls.Add(this.textDeviceName);
            this.Controls.Add(this.labelDeviceNameExplanation);
            this.Name = "NewDeviceNamePage";
            this.Size = new System.Drawing.Size(434, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeviceNameExplanation;
        private System.Windows.Forms.TextBox textDeviceName;
        private System.Windows.Forms.Label labelDeviceNameTip;
    }
}
