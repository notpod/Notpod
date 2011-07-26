/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 26.07.2011
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace iTunesAgent.UI.Controls
{
    partial class PlaylistAssociationBrowseFolder
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the control.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lblInfo = new System.Windows.Forms.Label();
        	this.btnBrowse = new System.Windows.Forms.Button();
        	this.lblSelectedDestination = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// lblInfo
        	// 
        	this.lblInfo.Location = new System.Drawing.Point(4, 4);
        	this.lblInfo.Name = "lblInfo";
        	this.lblInfo.Size = new System.Drawing.Size(505, 21);
        	this.lblInfo.TabIndex = 0;
        	this.lblInfo.Text = "Please choose the folder on your device where you want the music copied to:";
        	// 
        	// btnBrowse
        	// 
        	this.btnBrowse.Location = new System.Drawing.Point(101, 44);
        	this.btnBrowse.Name = "btnBrowse";
        	this.btnBrowse.Size = new System.Drawing.Size(303, 51);
        	this.btnBrowse.TabIndex = 1;
        	this.btnBrowse.Text = "Browse";
        	this.btnBrowse.UseVisualStyleBackColor = true;
        	this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
        	// 
        	// lblSelectedDestination
        	// 
        	this.lblSelectedDestination.Location = new System.Drawing.Point(4, 125);
        	this.lblSelectedDestination.Name = "lblSelectedDestination";
        	this.lblSelectedDestination.Size = new System.Drawing.Size(505, 92);
        	this.lblSelectedDestination.TabIndex = 2;
        	// 
        	// PlaylistAssociationBrowseFolder
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.lblSelectedDestination);
        	this.Controls.Add(this.btnBrowse);
        	this.Controls.Add(this.lblInfo);
        	this.Name = "PlaylistAssociationBrowseFolder";
        	this.Size = new System.Drawing.Size(512, 318);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblSelectedDestination;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblInfo;
    }
}
