using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;
namespace iTunesAgent.UI.Components.Wizard
{
    [TestFixture]
    public class WizardFormTest
    {
        MockRepository mock = new MockRepository();

        [Test]
        [ExpectedException(typeof(NoWizardPagesException))]
        public void StartWizard_WhenNoPagesAdded_ShouldThrowException()
        {
            WizardForm form = new WizardForm();
            form.StartWizard(null);
        }
                
    }
}
