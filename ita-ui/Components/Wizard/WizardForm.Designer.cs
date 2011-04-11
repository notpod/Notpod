namespace iTunesAgent.UI.Components.Wizard
{
    partial class WizardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.wizardContentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.panelWizardPageContainer = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.wizardContentPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.wizardContentPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(562, 436);
            this.mainPanel.TabIndex = 0;
            // 
            // wizardContentPanel
            // 
            this.wizardContentPanel.ColumnCount = 1;
            this.wizardContentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wizardContentPanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.wizardContentPanel.Controls.Add(this.panelHeader, 0, 0);
            this.wizardContentPanel.Controls.Add(this.panelWizardPageContainer, 0, 1);
            this.wizardContentPanel.Location = new System.Drawing.Point(3, 3);
            this.wizardContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.wizardContentPanel.Name = "wizardContentPanel";
            this.wizardContentPanel.RowCount = 3;
            this.wizardContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.wizardContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wizardContentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.wizardContentPanel.Size = new System.Drawing.Size(557, 433);
            this.wizardContentPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.buttonFinish);
            this.buttonsPanel.Controls.Add(this.buttonCancel);
            this.buttonsPanel.Controls.Add(this.buttonNext);
            this.buttonsPanel.Controls.Add(this.buttonBack);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 386);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(551, 44);
            this.buttonsPanel.TabIndex = 0;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(450, 4);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(99, 34);
            this.buttonFinish.TabIndex = 3;
            this.buttonFinish.Text = "&Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(6, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 34);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(345, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(99, 34);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(240, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 34);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "&Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SkyBlue;
            this.panelHeader.Controls.Add(this.labelPageTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(557, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPageTitle.Location = new System.Drawing.Point(3, 3);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(546, 41);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "WizardPageTitle";
            this.labelPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelWizardPageContainer
            // 
            this.panelWizardPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWizardPageContainer.Location = new System.Drawing.Point(3, 53);
            this.panelWizardPageContainer.Name = "panelWizardPageContainer";
            this.panelWizardPageContainer.Size = new System.Drawing.Size(551, 327);
            this.panelWizardPageContainer.TabIndex = 2;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(562, 436);
            this.Controls.Add(this.mainPanel);
            this.Name = "WizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WizardForm";
            this.mainPanel.ResumeLayout(false);
            this.wizardContentPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel wizardContentPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        System.Windows.Forms.Button buttonFinish;
        System.Windows.Forms.Button buttonCancel;
        System.Windows.Forms.Button buttonNext;
        System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Panel panelWizardPageContainer;
    }
}