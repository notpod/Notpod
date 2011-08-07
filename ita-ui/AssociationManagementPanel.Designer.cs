/*
 * Created by SharpDevelop.
 * User: Jaran
 * Date: 07.08.2011
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace iTunesAgent.UI
{
    partial class AssociationManagementPanel
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
        	this.panelLayout = new System.Windows.Forms.TableLayoutPanel();
        	this.lblPlaylistAssociations = new System.Windows.Forms.Label();
        	this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
        	this.lblWhereAmI = new System.Windows.Forms.Label();
        	this.listAssociatedDevices = new System.Windows.Forms.ListBox();
        	this.panelButtonContainer = new System.Windows.Forms.Panel();
        	this.btnNew = new System.Windows.Forms.Button();
        	this.btnEdit = new System.Windows.Forms.Button();
        	this.btnDelete = new System.Windows.Forms.Button();
        	this.btnBack = new System.Windows.Forms.Button();
        	this.panelLayout.SuspendLayout();
        	this.panelContent.SuspendLayout();
        	this.panelButtonContainer.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panelLayout
        	// 
        	this.panelLayout.ColumnCount = 1;
        	this.panelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.panelLayout.Controls.Add(this.lblPlaylistAssociations, 0, 0);
        	this.panelLayout.Controls.Add(this.panelContent, 0, 1);
        	this.panelLayout.Controls.Add(this.panelButtonContainer, 0, 2);
        	this.panelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panelLayout.Location = new System.Drawing.Point(0, 0);
        	this.panelLayout.Name = "panelLayout";
        	this.panelLayout.RowCount = 3;
        	this.panelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
        	this.panelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.panelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        	this.panelLayout.Size = new System.Drawing.Size(636, 358);
        	this.panelLayout.TabIndex = 0;
        	// 
        	// lblPlaylistAssociations
        	// 
        	this.lblPlaylistAssociations.AutoSize = true;
        	this.lblPlaylistAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lblPlaylistAssociations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblPlaylistAssociations.Image = global::iTunesAgent.UI.Properties.Resources.playlist;
        	this.lblPlaylistAssociations.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.lblPlaylistAssociations.Location = new System.Drawing.Point(5, 0);
        	this.lblPlaylistAssociations.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
        	this.lblPlaylistAssociations.Name = "lblPlaylistAssociations";
        	this.lblPlaylistAssociations.Size = new System.Drawing.Size(628, 50);
        	this.lblPlaylistAssociations.TabIndex = 4;
        	this.lblPlaylistAssociations.Text = "Playlist associations";
        	this.lblPlaylistAssociations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// panelContent
        	// 
        	this.panelContent.Controls.Add(this.lblWhereAmI);
        	this.panelContent.Controls.Add(this.listAssociatedDevices);
        	this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panelContent.Location = new System.Drawing.Point(3, 53);
        	this.panelContent.Name = "panelContent";
        	this.panelContent.Size = new System.Drawing.Size(630, 262);
        	this.panelContent.TabIndex = 7;
        	// 
        	// lblWhereAmI
        	// 
        	this.lblWhereAmI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblWhereAmI.Location = new System.Drawing.Point(3, 0);
        	this.lblWhereAmI.Name = "lblWhereAmI";
        	this.lblWhereAmI.Size = new System.Drawing.Size(627, 29);
        	this.lblWhereAmI.TabIndex = 0;
        	this.lblWhereAmI.Text = "Associations >> Playlist name";
        	// 
        	// listAssociatedDevices
        	// 
        	this.listAssociatedDevices.FormattingEnabled = true;
        	this.listAssociatedDevices.Location = new System.Drawing.Point(3, 32);
        	this.listAssociatedDevices.Name = "listAssociatedDevices";
        	this.listAssociatedDevices.Size = new System.Drawing.Size(627, 225);
        	this.listAssociatedDevices.TabIndex = 1;
        	// 
        	// panelButtonContainer
        	// 
        	this.panelButtonContainer.Controls.Add(this.btnNew);
        	this.panelButtonContainer.Controls.Add(this.btnEdit);
        	this.panelButtonContainer.Controls.Add(this.btnDelete);
        	this.panelButtonContainer.Controls.Add(this.btnBack);
        	this.panelButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panelButtonContainer.Location = new System.Drawing.Point(3, 321);
        	this.panelButtonContainer.Name = "panelButtonContainer";
        	this.panelButtonContainer.Size = new System.Drawing.Size(630, 34);
        	this.panelButtonContainer.TabIndex = 8;
        	// 
        	// btnNew
        	// 
        	this.btnNew.Location = new System.Drawing.Point(239, 3);
        	this.btnNew.Name = "btnNew";
        	this.btnNew.Size = new System.Drawing.Size(89, 28);
        	this.btnNew.TabIndex = 3;
        	this.btnNew.Text = "Add";
        	this.btnNew.UseVisualStyleBackColor = true;
        	// 
        	// btnEdit
        	// 
        	this.btnEdit.Location = new System.Drawing.Point(443, 3);
        	this.btnEdit.Name = "btnEdit";
        	this.btnEdit.Size = new System.Drawing.Size(89, 28);
        	this.btnEdit.TabIndex = 2;
        	this.btnEdit.Text = "Edit";
        	this.btnEdit.UseVisualStyleBackColor = true;
        	// 
        	// btnDelete
        	// 
        	this.btnDelete.Location = new System.Drawing.Point(538, 3);
        	this.btnDelete.Name = "btnDelete";
        	this.btnDelete.Size = new System.Drawing.Size(89, 28);
        	this.btnDelete.TabIndex = 1;
        	this.btnDelete.Text = "Delete";
        	this.btnDelete.UseVisualStyleBackColor = true;
        	// 
        	// btnBack
        	// 
        	this.btnBack.Location = new System.Drawing.Point(3, 3);
        	this.btnBack.Name = "btnBack";
        	this.btnBack.Size = new System.Drawing.Size(89, 28);
        	this.btnBack.TabIndex = 0;
        	this.btnBack.Text = "<< Back";
        	this.btnBack.UseVisualStyleBackColor = true;
        	this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
        	// 
        	// AssociationManagementPanel
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoSize = true;
        	this.Controls.Add(this.panelLayout);
        	this.Name = "AssociationManagementPanel";
        	this.Size = new System.Drawing.Size(636, 358);
        	this.ParentChanged += new System.EventHandler(this.ParentChangedHandler);
        	this.panelLayout.ResumeLayout(false);
        	this.panelLayout.PerformLayout();
        	this.panelContent.ResumeLayout(false);
        	this.panelButtonContainer.ResumeLayout(false);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panelButtonContainer;
        private System.Windows.Forms.ListBox listAssociatedDevices;
        private System.Windows.Forms.Label lblWhereAmI;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Label lblPlaylistAssociations;
        private System.Windows.Forms.TableLayoutPanel panelLayout;
    }
}
