using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Components.Wizard;
namespace iTunesAgent.UI.Controls
{
    public partial class NewDeviceMSDConfigurationPage : AbstractWizardPage
    {
        public NewDeviceMSDConfigurationPage()
        {
            InitializeComponent();
        }

        public override void Populate()
        {
            
        }

        public override bool ValidateBeforeNext()
        {
            return base.ValidateBeforeNext();
        }

    }
}
