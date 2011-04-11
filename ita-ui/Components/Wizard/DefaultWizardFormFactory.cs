using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.UI.Components.Wizard
{
    public class DefaultWizardFormFactory : IWizardFormFactory
    {

        public WizardForm NewForm()
        {
            return new WizardForm();
        }
    }
}
