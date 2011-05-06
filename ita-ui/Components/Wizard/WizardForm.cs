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

        public WizardForm()
        {
            InitializeComponent();
        }

        public Control PageContainer
        {
            get { return panelWizardPageContainer; }
        }

        public Label LabelPageTitle
        {
            get { return labelPageTitle; }
        }

        public Button NextButton
        {
            get { return buttonNext; }
        }

        public Button BackButton
        {
            get { return buttonBack; }
        }

        public Button FinishButton
        {
            get { return buttonFinish; }
        }

        public Button CancelButtonObject
        {
            get { return buttonCancel; }
        }

    }
}
