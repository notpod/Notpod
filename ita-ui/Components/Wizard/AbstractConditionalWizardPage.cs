using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI.Components.Wizard
{

    /// <summary>
    /// Abstract wizard page which is used for displaying different pages based on a condition.
    /// </summary>    

    public abstract partial class AbstractConditionalWizardPage : AbstractWizardPage
    {

        public abstract AbstractWizardPage GetWizardPage();


    }
}
