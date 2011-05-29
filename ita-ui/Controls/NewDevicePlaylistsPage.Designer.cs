namespace iTunesAgent.UI.Controls
{
    partial class NewDevicePlaylistsPage
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
            this.labelPlaylistsInfo = new System.Windows.Forms.Label();
            this.lvPlaylists = new System.Windows.Forms.ListView();
            this.colHeadPlaylistName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadToFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaylistsInfo
            // 
            this.labelPlaylistsInfo.Location = new System.Drawing.Point(3, 6);
            this.labelPlaylistsInfo.Name = "labelPlaylistsInfo";
            this.labelPlaylistsInfo.Size = new System.Drawing.Size(514, 16);
            this.labelPlaylistsInfo.TabIndex = 0;
            this.labelPlaylistsInfo.Text = "Manage playlists associated with this device.";
            // 
            // lvPlaylists
            // 
            this.lvPlaylists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadPlaylistName,
            this.colHeadToFolder});
            this.lvPlaylists.FullRowSelect = true;
            this.lvPlaylists.GridLines = true;
            this.lvPlaylists.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPlaylists.HoverSelection = true;
            this.lvPlaylists.LabelEdit = true;
            this.lvPlaylists.Location = new System.Drawing.Point(3, 25);
            this.lvPlaylists.Name = "lvPlaylists";
            this.lvPlaylists.Size = new System.Drawing.Size(514, 243);
            this.lvPlaylists.TabIndex = 1;
            this.lvPlaylists.UseCompatibleStateImageBehavior = false;
            this.lvPlaylists.View = System.Windows.Forms.View.Details;
            // 
            // colHeadPlaylistName
            // 
            this.colHeadPlaylistName.Text = "Playlist";
            this.colHeadPlaylistName.Width = 250;
            // 
            // colHeadToFolder
            // 
            this.colHeadToFolder.Text = "Copy to folder";
            this.colHeadToFolder.Width = 250;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 275);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(87, 274);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "&Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // NewDevicePlaylistsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.lvPlaylists);
            this.Controls.Add(this.labelPlaylistsInfo);
            this.Name = "NewDevicePlaylistsPage";
            this.Size = new System.Drawing.Size(520, 322);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlaylistsInfo;
        private System.Windows.Forms.ListView lvPlaylists;
        private System.Windows.Forms.ColumnHeader colHeadPlaylistName;
        private System.Windows.Forms.ColumnHeader colHeadToFolder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
    }
}
