namespace iTunesAgent.UI.Controls
{
    partial class NewDeviceWelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDeviceWelcomePage));
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelWelcomeInfo = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelWelcomeInfo);
            this.panelMain.Controls.Add(this.labelWelcome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(512, 308);
            this.panelMain.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(3, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(497, 23);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to the New Device wizard!";
            // 
            // labelWelcomeInfo
            // 
            this.labelWelcomeInfo.Location = new System.Drawing.Point(3, 32);
            this.labelWelcomeInfo.Name = "labelWelcomeInfo";
            this.labelWelcomeInfo.Padding = new System.Windows.Forms.Padding(5);
            this.labelWelcomeInfo.Size = new System.Drawing.Size(506, 276);
            this.labelWelcomeInfo.TabIndex = 1;
            this.labelWelcomeInfo.Text = resources.GetString("labelWelcomeInfo.Text");
            // 
            // NewDeviceWelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "NewDeviceWelcomePage";
            this.Size = new System.Drawing.Size(512, 308);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelWelcomeInfo;
        private System.Windows.Forms.Label labelWelcome;
    }
}
