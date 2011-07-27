/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 20.07.2011
 * Time: 15:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace iTunesAgent.UI.Controls
{
	partial class PlaylistAssociationChooseDevicePage
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
			this.cbDevices = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.Location = new System.Drawing.Point(3, 5);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(506, 18);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "Choose the device you want to associate with the playlist:";
			// 
			// cbDevices
			// 
			this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDevices.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDevices.FormattingEnabled = true;
			this.cbDevices.Location = new System.Drawing.Point(4, 37);
			this.cbDevices.Name = "cbDevices";
			this.cbDevices.Size = new System.Drawing.Size(505, 22);
			this.cbDevices.TabIndex = 1;
			// 
			// PlaylistAssociationChooseDevicePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbDevices);
			this.Controls.Add(this.lblInfo);
			this.Name = "PlaylistAssociationChooseDevicePage";
			this.Size = new System.Drawing.Size(512, 308);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbDevices;
		private System.Windows.Forms.Label lblInfo;
	}
}
