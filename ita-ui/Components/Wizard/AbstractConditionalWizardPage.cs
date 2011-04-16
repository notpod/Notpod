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
#if DEBUG
    // This is a hack to prevent the Visual Studio designer to crash on abstract user controls. 
    // Ref: http://social.msdn.microsoft.com/forums/en-US/winformsdesigner/thread/ddbc181f-dda4-48ba-94b3-194494c6b1e1/
    public partial class AbstractConditionalWizardPage : AbstractWizardPage
#else 
    public abstract class AbstractConditionalWizardPage : AbstractWizardPage
#endif
    {

#if DEBUG
        public virtual AbstractWizardPage GetWizardPage() { return null; }
#else
        public abstract AbstractWizardPage GetWizardPage();
#endif

    }
}
