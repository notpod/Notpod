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

        private LinkedList<AbstractWizardPage> pages = new LinkedList<AbstractWizardPage>();

        private int currentPage = 0;

        private WizardDataStore dataStore = new WizardDataStore();

        public WizardForm()
        {
            InitializeComponent();
        }


        public LinkedList<AbstractWizardPage> Pages
        {
            get { return pages; }
        }

        public WizardDataStore DataStore
        {
            get { return dataStore; }
        }

        /// <summary>
        /// Start the wizard by displaying the first page.
        /// </summary>
        /// <param name="owner"></param>
        public void StartWizard(IWin32Window owner)
        {
            ValidatePages();

            NextPage();

            if (owner == null)
            {
                ShowDialog();
            }
            else
            {
                ShowDialog(owner);
            }


        }

        private void ApplyControlOverrideRules()
        {
            if (pages.Count == 1)
            {
                // Cancel button always enabled if only one page.
                buttonCancel.Enabled = true;                
            }

            if (currentPage == pages.Count)
            {
                buttonNext.Enabled = false;
            }

            if (currentPage == 0)
            {
                buttonBack.Enabled = false;
            }
        }

        private void SetControlsForPage(AbstractWizardPage page)
        {
            buttonCancel.Enabled = page.CancelEnabled;
            buttonBack.Enabled = page.BackEnabled;
            buttonNext.Enabled = page.NextEnabled;
            buttonFinish.Enabled = page.FinishEnabled;
        }

        private void ValidatePages()
        {
            if (pages.Count == 0)
            {
                throw new NoWizardPagesException("Please add at least one before starting the wizard.");
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pages.ElementAt(currentPage - 1).ValidateBeforeNext())
            {
                NextPage();
            }
        }

        private void NextPage()
        {
            AbstractWizardPage page = pages.ElementAt(currentPage++);
            page.Populate();
            page.DataStore = dataStore;
            SetControlsForPage(page);
            ApplyControlOverrideRules();
            labelPageTitle.Text = page.PageTitle;
            panelWizardPageContainer.Controls.Clear();
            panelWizardPageContainer.Controls.Add(page);
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (pages.ElementAt(currentPage - 1).ValidateBeforeNext())
            {
                Close();
            }
        }
    }
}
