using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.UI.Components.Wizard
{
    /// <summary>
    /// Interface for wizard form factories.
    /// </summary>
    public interface IWizardFormFactory
    {

        WizardForm NewForm();

    }
}
