using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI.Components.Wizard
{
    public partial class WizardForm : Form
    {

        private List<AbstractWizardPage> pages = new List<AbstractWizardPage>();

        public WizardForm()
        {
            InitializeComponent();
        }
    }
}
