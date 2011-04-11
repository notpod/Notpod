using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI.Components.Wizard
{
    public partial class WizardForm : Form
    {

       

        public WizardForm()
        {
            InitializeComponent();
        }


        

        //private void buttonCancel_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void buttonNext_Click(object sender, EventArgs e)
        //{
        //    if (pages.ElementAt(currentPage - 1).ValidateBeforeNext())
        //    {
        //        NextPage();
        //    }
        //}

        //private void NextPage()
        //{
        //    AbstractWizardPage page = pages.ElementAt(currentPage++);
        //    page.Populate();
        //    page.DataStore = dataStore;
        //    SetControlsForPage(page);
        //    ApplyControlOverrideRules();
        //    labelPageTitle.Text = page.PageTitle;
        //    panelWizardPageContainer.Controls.Clear();
        //    panelWizardPageContainer.Controls.Add(page);
        //}

        //private void buttonFinish_Click(object sender, EventArgs e)
        //{
        //    if (pages.ElementAt(currentPage - 1).ValidateBeforeNext())
        //    {
        //        Close();
        //    }
        //}

        public Control PageContainer
        {
            get { return panelWizardPageContainer; }
        }

        public Label LabelPageTitle
        {
            get { return labelPageTitle; }
        }

        public Button NextButton
        {
            get { return buttonNext; }
        }

        public Button BackButton
        {
            get { return buttonBack; }
        }

        public Button FinishButton
        {
            get { return buttonFinish; }
        }

        public Button CancelButtonObject
        {
            get { return buttonCancel; }
        }

    }
}
