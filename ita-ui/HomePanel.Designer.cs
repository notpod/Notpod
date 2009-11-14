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
            this.tableLayoutHome = new System.Windows.Forms.TableLayoutPanel();
            this.gbITunesStatus = new System.Windows.Forms.GroupBox();
            this.labelDevicesStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelITunesStatus = new System.Windows.Forms.Label();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVersionInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToolHelp = new System.Windows.Forms.Button();
            this.buttonToolAddDevice = new System.Windows.Forms.Button();
            this.buttonWWW = new System.Windows.Forms.Button();
            this.tableLayoutHome.SuspendLayout();
            this.gbITunesStatus.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutHome
            // 
            this.tableLayoutHome.ColumnCount = 1;
            this.tableLayoutHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutHome.Controls.Add(this.label1, 0, 0);
            this.tableLayoutHome.Controls.Add(this.gbITunesStatus, 0, 1);
            this.tableLayoutHome.Controls.Add(this.gbTools, 0, 2);
            this.tableLayoutHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutHome.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutHome.Name = "tableLayoutHome";
            this.tableLayoutHome.RowCount = 3;
            this.tableLayoutHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutHome.Size = new System.Drawing.Size(477, 342);
            this.tableLayoutHome.TabIndex = 0;
            // 
            // gbITunesStatus
            // 
            this.gbITunesStatus.AutoSize = true;
            this.gbITunesStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbITunesStatus.Controls.Add(this.labelVersionInformation);
            this.gbITunesStatus.Controls.Add(this.label2);
            this.gbITunesStatus.Controls.Add(this.labelDevicesStatus);
            this.gbITunesStatus.Controls.Add(this.label4);
            this.gbITunesStatus.Controls.Add(this.label3);
            this.gbITunesStatus.Controls.Add(this.labelITunesStatus);
            this.gbITunesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbITunesStatus.Location = new System.Drawing.Point(3, 53);
            this.gbITunesStatus.Name = "gbITunesStatus";
            this.gbITunesStatus.Size = new System.Drawing.Size(471, 140);
            this.gbITunesStatus.TabIndex = 1;
            this.gbITunesStatus.TabStop = false;
            // 
            // labelDevicesStatus
            // 
            this.labelDevicesStatus.Location = new System.Drawing.Point(72, 55);
            this.labelDevicesStatus.Name = "labelDevicesStatus";
            this.labelDevicesStatus.Size = new System.Drawing.Size(381, 21);
            this.labelDevicesStatus.TabIndex = 3;
            this.labelDevicesStatus.Text = "I am currenty not managing any devices for you.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Devices:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "iTunes:";
            // 
            // labelITunesStatus
            // 
            this.labelITunesStatus.Location = new System.Drawing.Point(72, 16);
            this.labelITunesStatus.Name = "labelITunesStatus";
            this.labelITunesStatus.Size = new System.Drawing.Size(381, 27);
            this.labelITunesStatus.TabIndex = 0;
            this.labelITunesStatus.Text = "I have not been able to detect any installation of iTunes on your computer. Pleas" +
                "e make sure iTunes is installed, then restart me.";
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.buttonWWW);
            this.gbTools.Controls.Add(this.buttonToolHelp);
            this.gbTools.Controls.Add(this.buttonToolAddDevice);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTools.Location = new System.Drawing.Point(3, 199);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(471, 140);
            this.gbTools.TabIndex = 2;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version information:";
            // 
            // labelVersionInformation
            // 
            this.labelVersionInformation.Location = new System.Drawing.Point(131, 95);
            this.labelVersionInformation.Name = "labelVersionInformation";
            this.labelVersionInformation.Size = new System.Drawing.Size(322, 33);
            this.labelVersionInformation.TabIndex = 5;
            this.labelVersionInformation.Text = "You are currently running version x.x. This is the newest version.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::iTunesAgent.UI.Properties.Resources.home;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonToolHelp
            // 
            this.buttonToolHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToolHelp.FlatAppearance.BorderSize = 0;
            this.buttonToolHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonToolHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToolHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToolHelp.Image = global::iTunesAgent.UI.Properties.Resources.help;
            this.buttonToolHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToolHelp.Location = new System.Drawing.Point(122, 19);
            this.buttonToolHelp.Name = "buttonToolHelp";
            this.buttonToolHelp.Size = new System.Drawing.Size(106, 76);
            this.buttonToolHelp.TabIndex = 1;
            this.buttonToolHelp.Text = "Get help";
            this.buttonToolHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonToolHelp.UseVisualStyleBackColor = true;
            // 
            // buttonToolAddDevice
            // 
            this.buttonToolAddDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToolAddDevice.FlatAppearance.BorderSize = 0;
            this.buttonToolAddDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonToolAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToolAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToolAddDevice.Image = global::iTunesAgent.UI.Properties.Resources.add;
            this.buttonToolAddDevice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonToolAddDevice.Location = new System.Drawing.Point(10, 19);
            this.buttonToolAddDevice.Name = "buttonToolAddDevice";
            this.buttonToolAddDevice.Size = new System.Drawing.Size(106, 76);
            this.buttonToolAddDevice.TabIndex = 0;
            this.buttonToolAddDevice.Text = "Add new device";
            this.buttonToolAddDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonToolAddDevice.UseVisualStyleBackColor = true;
            // 
            // buttonWWW
            // 
            this.buttonWWW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWWW.FlatAppearance.BorderSize = 0;
            this.buttonWWW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonWWW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWWW.Image = global::iTunesAgent.UI.Properties.Resources.globe;
            this.buttonWWW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWWW.Location = new System.Drawing.Point(234, 19);
            this.buttonWWW.Name = "buttonWWW";
            this.buttonWWW.Size = new System.Drawing.Size(106, 76);
            this.buttonWWW.TabIndex = 2;
            this.buttonWWW.Text = "Go to web site";
            this.buttonWWW.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWWW.UseVisualStyleBackColor = true;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutHome);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(477, 342);
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
        private System.Windows.Forms.Label labelITunesStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDevicesStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Button buttonToolAddDevice;
        private System.Windows.Forms.Button buttonToolHelp;
        private System.Windows.Forms.Label labelVersionInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWWW;
    }
}
