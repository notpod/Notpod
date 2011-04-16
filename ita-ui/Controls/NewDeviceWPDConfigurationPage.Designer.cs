namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceWPDConfigurationPage
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
            this.listWPDDevices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelInfoTop
            // 
            this.labelInfoTop.AutoSize = true;
            this.labelInfoTop.Location = new System.Drawing.Point(3, 9);
            this.labelInfoTop.Name = "labelInfoTop";
            this.labelInfoTop.Size = new System.Drawing.Size(316, 13);
            this.labelInfoTop.TabIndex = 0;
            this.labelInfoTop.Text = "Please choose your portable device among the ones listed below:";
            // 
            // listWPDDevices
            // 
            this.listWPDDevices.FormattingEnabled = true;
            this.listWPDDevices.Location = new System.Drawing.Point(3, 35);
            this.listWPDDevices.Name = "listWPDDevices";
            this.listWPDDevices.Size = new System.Drawing.Size(506, 251);
            this.listWPDDevices.TabIndex = 1;
            // 
            // NewDeviceWPDConfigurationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listWPDDevices);
            this.Controls.Add(this.labelInfoTop);
            this.Name = "NewDeviceWPDConfigurationPage";
            this.Size = new System.Drawing.Size(512, 308);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTop;
        private System.Windows.Forms.ListBox listWPDDevices;
    }
}
