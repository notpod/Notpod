using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iTunesAgent.UI.Components.Wizard
{
    public class WizardDataStore : Dictionary<string, object>
    {
        public new object this[string key]
        {
            get
            {
                try
                {
                    return base[key];
                }
                catch (Exception ex)
                {
                    return null;
                }

            }
            set
            {
                base[key] = value;
            }
        }
    }
}
