using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTunesAgent.UI.Properties;
using iTunesAgent.Services;
using iTunesAgent.Services.iTunes;

namespace iTunesAgent.UI
{
    public partial class HomePanel : UserControl, ITranslatable
    {
        private ModelRepository model;

        private Dictionary<string, MediaSoftwareService> mediaSoftwareServices; 

        public HomePanel()
        {
            InitializeComponent();            
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            TranslationMgr.Attach(this);
            UpdatePanel();            
        }

        private void UpdatePanel()
        {
            UpdateVersionInformation();
            UpdateMediaSoftwareInformation();
        }

        private void UpdateMediaSoftwareInformation()
        {
            
            if(mediaSoftwareServices.Count == 0) {

                labelMediaSoftwareStatus.Text = Resources.StrNoITunesDetected;
                return;
            }

            string mediaSoftwareStatus = "";
                
            foreach(MediaSoftwareService service in mediaSoftwareServices.Values) {
                mediaSoftwareStatus += service.Name + " " + service.Version;
            }

            labelMediaSoftwareStatus.Text = mediaSoftwareStatus;
        }

        private void UpdateVersionInformation()
        {
            labelVersionInformation.Text = Resources.StrHomePanelYouAreRunningVersion + ", " + Application.ProductVersion;
        }

        public ModelRepository Model
        {
            set { model = value; }
            get { return model; }
        }

        #region ITranslatable Members

        public void OnTranslate()
        {
            labelMediaSoftwareStatus.Text = Resources.StrNoITunesDetected;
            labelDevicesStatus.Text = Resources.StrNoDevicesManaged;

            UpdatePanel();
        }

        #endregion

        public Dictionary<string, MediaSoftwareService> MediaSoftwareServices
        {
            get { return mediaSoftwareServices; }
            set { mediaSoftwareServices = value; }
        }
    }
}
