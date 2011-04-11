using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI.Components.Wizard
{
    /// <summary>
    /// Abstact base class for wizard pages.
    /// </summary>
#if DEBUG
    // This is a hack to prevent the Visual Studio designer to crash on abstract user controls. 
    // Ref: http://social.msdn.microsoft.com/forums/en-US/winformsdesigner/thread/ddbc181f-dda4-48ba-94b3-194494c6b1e1/
    public class AbstractWizardPage : UserControl
#else 
    public abstract class AbstractWizardPage : UserControl
#endif
    {

        private WizardDataStore dataStore;

        private string pageTitle = "";

        private bool nextEnabled = true;

        private bool backEnabled = true;

        private bool finishEnabled = true;

        public WizardDataStore DataStore
        {
            get { return dataStore; }
            set { this.dataStore = value; }
        }

        public string PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }

        #region Button enabler/disablers
        public bool NextEnabled
        {
            get { return nextEnabled; }
            set { nextEnabled = value; }
        }
               
        public bool BackEnabled
        {
            get { return backEnabled; }
            set { backEnabled = value; }
        }

        public bool FinishEnabled
        {
            get { return finishEnabled; }
            set { finishEnabled = value; }
        }
        #endregion

        /// <summary>
        /// Implement this method to populate your wizard page with data before it is displayed.
        /// </summary>
#if DEBUG         
        public virtual void Populate() {}
#else 
        public abstract void Populate();
#endif

        /// <summary>
        /// This method will be called by the wizard just before it jumps to the next page. 
        /// You should implement any necessary data validation here before moving forward. 
        /// When everything is ready and you have persisted the necessary data to the 
        /// dataStore, return true.
        /// </summary>
        /// <returns>True if the page is ready to move forward, false if the wizard should 
        /// stay on the current page.</returns>
#if DEBUG
        public virtual bool ValidateBeforeNext() { return true; }
#else 
        public abstract bool ValidateBeforeNext();
#endif

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AbstractWizardPage
            // 
            this.Name = "AbstractWizardPage";
            this.Size = new System.Drawing.Size(500, 316);
            this.ResumeLayout(false);

        }

    }
}
