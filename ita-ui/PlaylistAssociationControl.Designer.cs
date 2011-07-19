namespace iTunesAgent.UI
{
    partial class PlaylistAssociationControl
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
            this.components = new System.ComponentModel.Container();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblAssociationCount = new System.Windows.Forms.Label();
            this.btnEditAssociations = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSynchronizeNow = new System.Windows.Forms.Button();
            this.btnAddAssociation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(1, 1);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(170, 14);
            this.lblPlaylistName.TabIndex = 0;
            this.lblPlaylistName.Text = "Playlist name";
            this.lblPlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAssociationCount
            // 
            this.lblAssociationCount.Location = new System.Drawing.Point(1, 18);
            this.lblAssociationCount.Name = "lblAssociationCount";
            this.lblAssociationCount.Size = new System.Drawing.Size(170, 14);
            this.lblAssociationCount.TabIndex = 1;
            this.lblAssociationCount.Text = "Will be copied to X devices";
            // 
            // btnEditAssociations
            // 
            this.btnEditAssociations.FlatAppearance.BorderSize = 0;
            this.btnEditAssociations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAssociations.Image = global::iTunesAgent.UI.Properties.Resources.associations;
            this.btnEditAssociations.Location = new System.Drawing.Point(26, 37);
            this.btnEditAssociations.Name = "btnEditAssociations";
            this.btnEditAssociations.Size = new System.Drawing.Size(16, 16);
            this.btnEditAssociations.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnEditAssociations, "Manage associations");
            this.btnEditAssociations.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::iTunesAgent.UI.Properties.Resources.remove;
            this.button1.Location = new System.Drawing.Point(50, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 3;
            this.toolTip.SetToolTip(this.button1, "Remove all associations for this playlist and remove it from iTunes Agent");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSynchronizeNow
            // 
            this.btnSynchronizeNow.FlatAppearance.BorderSize = 0;
            this.btnSynchronizeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSynchronizeNow.Image = global::iTunesAgent.UI.Properties.Resources.download;
            this.btnSynchronizeNow.Location = new System.Drawing.Point(147, 37);
            this.btnSynchronizeNow.Name = "btnSynchronizeNow";
            this.btnSynchronizeNow.Size = new System.Drawing.Size(16, 16);
            this.btnSynchronizeNow.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnSynchronizeNow, "Synchronize this playlist now.");
            this.btnSynchronizeNow.UseVisualStyleBackColor = true;
            // 
            // btnAddAssociation
            // 
            this.btnAddAssociation.FlatAppearance.BorderSize = 0;
            this.btnAddAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssociation.Image = global::iTunesAgent.UI.Properties.Resources.add_small;
            this.btnAddAssociation.Location = new System.Drawing.Point(3, 37);
            this.btnAddAssociation.Name = "btnAddAssociation";
            this.btnAddAssociation.Size = new System.Drawing.Size(16, 16);
            this.btnAddAssociation.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnAddAssociation, "Add new association for this playlist.");
            this.btnAddAssociation.UseVisualStyleBackColor = true;
            // 
            // PlaylistAssociationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAddAssociation);
            this.Controls.Add(this.btnSynchronizeNow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditAssociations);
            this.Controls.Add(this.lblAssociationCount);
            this.Controls.Add(this.lblPlaylistName);
            this.Name = "PlaylistAssociationControl";
            this.Size = new System.Drawing.Size(170, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblAssociationCount;
        private System.Windows.Forms.Button btnEditAssociations;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSynchronizeNow;
        private System.Windows.Forms.Button btnAddAssociation;
    }
}
