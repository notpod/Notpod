namespace iTunesAgent.UI
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.tableLayoutHome = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbITunesStatus = new System.Windows.Forms.GroupBox();
            this.labelMediaSoftwareStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDevicesStatus = new System.Windows.Forms.Label();
            this.labelVersionInformation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.buttonWWW = new System.Windows.Forms.Button();
            this.buttonToolHelp = new System.Windows.Forms.Button();
            this.buttonToolAddDevice = new System.Windows.Forms.Button();
            this.tableLayoutHome.SuspendLayout();
            this.gbITunesStatus.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutHome
            // 
            resources.ApplyResources(this.tableLayoutHome, "tableLayoutHome");
            this.tableLayoutHome.Controls.Add(this.label1, 0, 0);
            this.tableLayoutHome.Controls.Add(this.gbITunesStatus, 0, 1);
            this.tableLayoutHome.Controls.Add(this.gbTools, 0, 2);
            this.tableLayoutHome.Name = "tableLayoutHome";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::iTunesAgent.UI.Properties.Resources.home;
            this.label1.Name = "label1";
            // 
            // gbITunesStatus
            // 
            resources.ApplyResources(this.gbITunesStatus, "gbITunesStatus");
            this.gbITunesStatus.Controls.Add(this.labelMediaSoftwareStatus);
            this.gbITunesStatus.Controls.Add(this.label3);
            this.gbITunesStatus.Controls.Add(this.labelDevicesStatus);
            this.gbITunesStatus.Controls.Add(this.labelVersionInformation);
            this.gbITunesStatus.Controls.Add(this.label4);
            this.gbITunesStatus.Name = "gbITunesStatus";
            this.gbITunesStatus.TabStop = false;
            // 
            // labelMediaSoftwareStatus
            // 
            resources.ApplyResources(this.labelMediaSoftwareStatus, "labelMediaSoftwareStatus");
            this.labelMediaSoftwareStatus.Name = "labelMediaSoftwareStatus";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // labelDevicesStatus
            // 
            resources.ApplyResources(this.labelDevicesStatus, "labelDevicesStatus");
            this.labelDevicesStatus.Name = "labelDevicesStatus";
            // 
            // labelVersionInformation
            // 
            resources.ApplyResources(this.labelVersionInformation, "labelVersionInformation");
            this.labelVersionInformation.Name = "labelVersionInformation";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.buttonWWW);
            this.gbTools.Controls.Add(this.buttonToolHelp);
            this.gbTools.Controls.Add(this.buttonToolAddDevice);
            resources.ApplyResources(this.gbTools, "gbTools");
            this.gbTools.Name = "gbTools";
            this.gbTools.TabStop = false;
            // 
            // buttonWWW
            // 
            this.buttonWWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWWW.FlatAppearance.BorderSize = 0;
            this.buttonWWW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.buttonWWW, "buttonWWW");
            this.buttonWWW.Image = global::iTunesAgent.UI.Properties.Resources.globe;
            this.buttonWWW.Name = "buttonWWW";
            this.buttonWWW.UseVisualStyleBackColor = true;
            // 
            // buttonToolHelp
            // 
            this.buttonToolHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToolHelp.FlatAppearance.BorderSize = 0;
            this.buttonToolHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.buttonToolHelp, "buttonToolHelp");
            this.buttonToolHelp.Image = global::iTunesAgent.UI.Properties.Resources.help;
            this.buttonToolHelp.Name = "buttonToolHelp";
            this.buttonToolHelp.UseVisualStyleBackColor = true;
            // 
            // buttonToolAddDevice
            // 
            this.buttonToolAddDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToolAddDevice.FlatAppearance.BorderSize = 0;
            this.buttonToolAddDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.buttonToolAddDevice, "buttonToolAddDevice");
            this.buttonToolAddDevice.Image = global::iTunesAgent.UI.Properties.Resources.add;
            this.buttonToolAddDevice.Name = "buttonToolAddDevice";
            this.buttonToolAddDevice.UseVisualStyleBackColor = true;
            // 
            // HomePanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutHome);
            this.Name = "HomePanel";
            this.Load += new System.EventHandler(this.HomePanel_Load);
            this.tableLayoutHome.ResumeLayout(false);
            this.tableLayoutHome.PerformLayout();
            this.gbITunesStatus.ResumeLayout(false);
            this.gbITunesStatus.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbITunesStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button buttonToolAddDevice;
        private System.Windows.Forms.Button buttonToolHelp;
        private System.Windows.Forms.Label labelVersionInformation;
        private System.Windows.Forms.Button buttonWWW;
        private System.Windows.Forms.Label labelDevicesStatus;
        private System.Windows.Forms.Label labelMediaSoftwareStatus;
        private System.Windows.Forms.Label label3;
    }
}
