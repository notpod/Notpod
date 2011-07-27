namespace iTunesAgent.UI
{
    partial class PlaylistsPanel
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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlaylistAssociations = new System.Windows.Forms.Label();
            this.flowPlaylistAssociations = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButtonContainer = new System.Windows.Forms.Panel();
            this.btnAddAssociation = new System.Windows.Forms.Button();
            this.buttonSynchronizeAll = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.panelButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.lblPlaylistAssociations, 0, 0);
            this.tableLayout.Controls.Add(this.flowPlaylistAssociations, 0, 1);
            this.tableLayout.Controls.Add(this.panelButtonContainer, 0, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayout.Size = new System.Drawing.Size(636, 358);
            this.tableLayout.TabIndex = 0;
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
            this.lblPlaylistAssociations.TabIndex = 3;
            this.lblPlaylistAssociations.Text = "Playlist associations";
            this.lblPlaylistAssociations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPlaylistAssociations
            // 
            this.flowPlaylistAssociations.AutoScroll = true;
            this.flowPlaylistAssociations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPlaylistAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPlaylistAssociations.Location = new System.Drawing.Point(3, 53);
            this.flowPlaylistAssociations.Name = "flowPlaylistAssociations";
            this.flowPlaylistAssociations.Size = new System.Drawing.Size(630, 262);
            this.flowPlaylistAssociations.TabIndex = 4;
            // 
            // panelButtonContainer
            // 
            this.panelButtonContainer.Controls.Add(this.buttonSynchronizeAll);
            this.panelButtonContainer.Controls.Add(this.btnAddAssociation);
            this.panelButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonContainer.Location = new System.Drawing.Point(3, 321);
            this.panelButtonContainer.Name = "panelButtonContainer";
            this.panelButtonContainer.Size = new System.Drawing.Size(630, 34);
            this.panelButtonContainer.TabIndex = 5;
            // 
            // btnAddAssociation
            // 
            this.btnAddAssociation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddAssociation.Location = new System.Drawing.Point(0, 0);
            this.btnAddAssociation.Name = "btnAddAssociation";
            this.btnAddAssociation.Size = new System.Drawing.Size(144, 34);
            this.btnAddAssociation.TabIndex = 6;
            this.btnAddAssociation.Text = "Add new association";
            this.btnAddAssociation.UseVisualStyleBackColor = true;
            // 
            // buttonSynchronizeAll
            // 
            this.buttonSynchronizeAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSynchronizeAll.Image = global::iTunesAgent.UI.Properties.Resources.download;
            this.buttonSynchronizeAll.Location = new System.Drawing.Point(442, 0);
            this.buttonSynchronizeAll.Name = "buttonSynchronizeAll";
            this.buttonSynchronizeAll.Size = new System.Drawing.Size(188, 34);
            this.buttonSynchronizeAll.TabIndex = 7;
            this.buttonSynchronizeAll.Text = "Synchonize all playlists now";
            this.buttonSynchronizeAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSynchronizeAll.UseVisualStyleBackColor = true;
            // 
            // PlaylistsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayout);
            this.Name = "PlaylistsPanel";
            this.Size = new System.Drawing.Size(636, 358);
            this.Load += new System.EventHandler(this.PlaylistsPanel_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.panelButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label lblPlaylistAssociations;
        private System.Windows.Forms.FlowLayoutPanel flowPlaylistAssociations;
        private System.Windows.Forms.Panel panelButtonContainer;
        private System.Windows.Forms.Button buttonSynchronizeAll;
        private System.Windows.Forms.Button btnAddAssociation;
    }
}
