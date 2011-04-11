using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace iTunesAgent.UI.Components.Wizard
{

    public delegate void CancelButtonClick(object sender, EventArgs e);

    public delegate void BackButtonClick(object sender, EventArgs e);

    public delegate void NextButtonClick(object sender, EventArgs e);

    public delegate void FinishButtonClick(object sender, EventArgs e);

    public interface IWizardForm
    {
        Control GetPageContainer();
        void SetCurrentPageTitle(string title);

        void ShowDialog();
        void ShowDialog(IWin32Window owner);

        event CancelButtonClick OnCancelButtonClick;
        event BackButtonClick OnBackButtonClick;
        event NextButtonClick OnNextButtonClick;
        event FinishButtonClick OnFinishButtonClick;
               
    }
}
