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
    public abstract class AbstractWizardPage : UserControl
    {

        private WizardDataStore dataStore;

        public WizardDataStore DataStore
        {
            get { return dataStore; }
            set { this.dataStore = value; }
        }

        /// <summary>
        /// Implement this method to populate your wizard page with data before it is displayed.
        /// </summary>
        public abstract void Populate();
                
    }
}
