using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI.Components.Wizard
{
    public class Wizard
    {

        private LinkedList<AbstractWizardPage> pages = new LinkedList<AbstractWizardPage>();

        private int currentPage = 0;

        private WizardDataStore dataStore = new WizardDataStore();

        private IWizardFormFactory wizardFormFactory = new DefaultWizardFormFactory();

        private WizardForm activeForm;

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

            activeForm = wizardFormFactory.NewForm();
            activeForm.CancelButtonObject.Click += new EventHandler(buttonCancel_Click);
            activeForm.BackButton.Click += new EventHandler(buttonBack_Click);
            activeForm.NextButton.Click += new EventHandler(buttonNext_Click);
            activeForm.FinishButton.Click += new EventHandler(buttonFinish_Click);

            NextPage();

            if (owner == null)
            {
                activeForm.ShowDialog();
            }
            else
            {
                activeForm.ShowDialog(owner);
            }


        }

        private void ApplyControlOverrideRules()
        {

            if (currentPage == pages.Count - 1)
            {
                activeForm.NextButton.Enabled = false;
            }

            if (currentPage == 0)
            {
                activeForm.BackButton.Enabled = false;
            }
        }

        private void SetControlsForPage(AbstractWizardPage page)
        {
            activeForm.BackButton.Enabled = page.BackEnabled;
            activeForm.NextButton.Enabled = page.NextEnabled;
            activeForm.FinishButton.Enabled = page.FinishEnabled;
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
            activeForm.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void PreviousPage()
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowPageAtIndex(currentPage);
            }
        }

        private void ShowPageAtIndex(int pageIndex)
        {
            AbstractWizardPage page = pages.ElementAt(pageIndex);
            if (page.GetType() == typeof(AbstractConditionalWizardPage))
            {
                page = ((AbstractConditionalWizardPage)page).GetWizardPage();
            }
            page.DataStore = dataStore;
            page.Populate();
            SetControlsForPage(page);
            ApplyControlOverrideRules();
            activeForm.LabelPageTitle.Text = page.PageTitle;
            activeForm.PageContainer.Controls.Clear();
            activeForm.PageContainer.Controls.Add(page);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!pages.ElementAt(currentPage).ValidateBeforeNext())
            {
                return;
            }

            NextPage();

        }

        private void NextPage()
        {
            if (currentPage < pages.Count - 1)
            {
                currentPage++;
                ShowPageAtIndex(currentPage);
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (pages.ElementAt(currentPage - 1).ValidateBeforeNext())
            {
                activeForm.Close();
            }
        }

        public IWizardFormFactory WizardFormFactory
        {
            get { return this.wizardFormFactory; }
            set { wizardFormFactory = value; }
        }

    }
}
