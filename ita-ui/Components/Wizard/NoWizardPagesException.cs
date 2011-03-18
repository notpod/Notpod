using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.UI.Components.Wizard
{
    public class NoWizardPagesException : Exception
    {
        public NoWizardPagesException() : base() 
        {
                        
        }

        public NoWizardPagesException(string message) : base(message)
        {
            
        }
    }
}
